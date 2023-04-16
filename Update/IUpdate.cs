using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using xmlExplain;

namespace Update
{
    internal class Resource
    {
        public string Name { get; set; }

        public string Md5 { get; set; }
    }

    internal abstract class IUpdate
    {
        protected readonly UpdateForm Form;

        protected readonly string Lzm = Path.Combine(UpdateForm.CurrentPath, "lzm.xml");

        protected readonly string Rzm = Path.Combine(UpdateForm.CurrentPath, "rzm.xml");

        internal IUpdate(UpdateForm form)
        {
            Form = form;
        }

        protected int Progress
        {
            set => Form.Progress = value;
        }

        public bool GetLocalVersion(ref string version)
        {
            if (!File.Exists(Lzm))
            {
                return false;
            }

            XmlReader reader = new XmlReader(Lzm);
            if (reader.Root != null && reader.Root.Attribute("version") != null)
            {
                version = reader.Root.Attribute("version").Value;
                return true;
            }

            return false;
        }

        protected List<Resource> GetResources(string manifest)
        {
            List<Resource> resources = new List<Resource>();
            XmlReader reader = new XmlReader(manifest);
            Node root = reader.Root;
            foreach (var rc in root.Child("rcs").Children)
            {
                string name = rc.Attribute("name").Value;
                string md5 = rc.Attribute("md5").Value;
                Resource res = new Resource
                {
                    Name = name,
                    Md5 = md5
                };
                resources.Add(res);
            }

            return resources;
        }

        public List<Resource> GetLocalResource()
        {
            if (!File.Exists(Lzm))
            {
                return new List<Resource>();
            }

            return GetResources(Lzm);
        }

        public bool UpdateSelf()
        {
            string localUpdate = Path.Combine(UpdateForm.CurrentPath, UpdateForm.UpdateName);
            string localMd5 = CalcMd5(localUpdate);
            File.Delete(Rzm);
            string remoteMd5 = GetRemoteSelfMd5();
            if (remoteMd5 == null)
                return false;
            if (localMd5 != null && localMd5 == remoteMd5)
                return false;

            Resource resource = new Resource
            {
                Name = UpdateForm.UpdateName,
                Md5 = remoteMd5
            };
            File.Move(localUpdate, localUpdate + ".bak");
            return DownloadFile(resource);
        }

        public bool CheckUpdate()
        {
            Form.State = "Checking update for workbench...";
            string localVersion = "0.0";
            string remoteVersion = "0.0";
            if (!GetRemoteVersion(ref remoteVersion))
            {
                return false;
            }

            if (!GetLocalVersion(ref localVersion))
            {
                return true;
            }

            return localVersion != remoteVersion;
        }

        public abstract string GetRemoteSelfMd5();

        private Resource GetLocalResource(string name, List<Resource> localResources)
        {
            foreach (var resource in localResources)
            {
                if (resource.Name == name)
                    return resource;
            }

            return null;
        }

        public bool Update()
        {
            List<Resource> localResources = GetLocalResource();
            List<Resource> remoteResources = GetRemoteResource();
            List<Resource> needUpdate = new List<Resource>();

            foreach (var remoteResource in remoteResources)
            {
                Resource localResource = GetLocalResource(remoteResource.Name, localResources);
                if (localResource == null || localResource.Md5 != remoteResource.Md5)
                    needUpdate.Add(remoteResource);
            }

            int index = 0;
            foreach (var resource in needUpdate)
            {
                if (!DownloadFile(resource))
                    return false;
                ++index;
                Progress = index * 100 / localResources.Count;
            }

            XmlReader reader = new XmlReader(Lzm);
            string remoteVersion = null;
            GetRemoteVersion(ref remoteVersion);
            reader.Root.Attribute("version").Value = remoteVersion;
            XmlWriter writer = new XmlWriter(Lzm);
            writer.Write(reader.Root);
            Progress = 100;
            return true;
        }

        public abstract List<Resource> GetRemoteResource();

        public abstract bool GetRemoteVersion(ref string version);

        public abstract bool DownloadFile(Resource resource);

        protected string CalcMd5(string path)
        {
            byte[] hash;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    hash = md5.ComputeHash(stream);
                }
            }

            string md5String = BitConverter.ToString(hash).Replace("-", "");
            return md5String.ToLower();
        }
    }

    internal class LocalUpdate : IUpdate
    {
        private readonly string _path;

        public LocalUpdate(UpdateForm form, string path) : base(form)
        {
            _path = path;
        }

        public override string GetRemoteSelfMd5()
        {
            string remoteUpdateMd5 = Path.Combine(_path, "rzm.xml");
            XmlReader reader = new XmlReader(remoteUpdateMd5);
            return reader.Root.Attribute("md5").Value;
        }

        public override List<Resource> GetRemoteResource()
        {
            string remoteManifest = Path.Combine(_path, "rzm.xml");
            return GetResources(remoteManifest);
        }

        public override bool GetRemoteVersion(ref string version)
        {
            string remoteUpdateMd5 = Path.Combine(_path, "rzm.xml");
            XmlReader reader = new XmlReader(remoteUpdateMd5);
            version = reader.Root.Attribute("version").Value;
            return true;
        }

        public override bool DownloadFile(Resource resource)
        {
            string remoteRes = Path.Combine(_path, resource.Name);
            string savePath = Path.Combine(UpdateForm.CurrentPath, resource.Name);

            try
            {
                File.Copy(remoteRes, savePath, true);
            }
            catch (Exception)
            {
                return false;
            }

            return CalcMd5(savePath) == resource.Md5;
        }
    }

    internal class HttpUpdate : IUpdate
    {
        private readonly string _url;

        public HttpUpdate(UpdateForm form, string url) : base(form)
        {
            _url = url;
            if (!_url.EndsWith("/"))
                _url += "/";
        }

        public override string GetRemoteSelfMd5()
        {
            if (Http.Download(_url + "rzm.xml", Rzm))
            {
                XmlReader reader = new XmlReader(Rzm);
                return reader.Root.Attribute("md5").Value;
            }

            return null;
        }

        public override List<Resource> GetRemoteResource()
        {
            return GetResources(Rzm);
        }

        public override bool GetRemoteVersion(ref string version)
        {
            try
            {
                XmlReader reader = new XmlReader(Rzm);
                version = reader.Root.Attribute("version").Value;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool DownloadFile(Resource resource)
        {
            string url = _url + resource.Name;
            string savePath = Path.Combine(UpdateForm.CurrentPath, resource.Name);
            if (!Http.Download(url, savePath))
                return false;
            return CalcMd5(savePath) == resource.Md5;
        }
    }
}