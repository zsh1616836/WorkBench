using System.Drawing;
using System.Windows.Forms;
using xmlExplain;

namespace WorkBench
{
    internal class Page : TabPage
    {
        public override Color BackColor { get; set; }


        public Page()
        {
        }

        public bool LoadConfigNode(Node page)
        {
            SuspendLayout();
            BackColor = Color.White;
            Text = page.Attribute("name").Value;
            Node node = page.Children[0];
            Controls.Clear();
            Control ctl = LayoutLoader.LoadControl(node);
            if (ctl != null)
                Controls.Add(ctl);
            ResumeLayout();
            return true;
        }
    }
}