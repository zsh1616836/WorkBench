using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkBench
{
    internal class ClickLinkLabel : LinkLabel
    {
        private bool _mouseDown = false;

        public ClickLinkLabel()
        {
            base.AutoSize = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (_mouseDown && ClientRectangle.Contains(e.Location))
            {
                OnLinkClicked(new LinkLabelLinkClickedEventArgs(Links[0]));
            }

            _mouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_mouseDown)
            {
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                    Color.Black, ButtonBorderStyle.Inset);
            }
        }
    }
}