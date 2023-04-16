using System.Drawing;
using System.Windows.Forms;

namespace Update
{
    public partial class ProgressBar : UserControl
    {
        private int _minValue;
        private int _maxValue;
        private int _current;

        public ProgressBar()
        {
            InitializeComponent();
            _maxValue = 100;
            _minValue = 0;
        }

        private ProgressBar(int min, int max)
        {
            _maxValue = max;
            _minValue = min;
        }

        public int MinValue
        {
            get => _minValue;
            set
            {
                _minValue = value;
                Invalidate();
            }
        }

        public int MaxValue
        {
            get => _maxValue;
            set
            {
                _maxValue = value;
                Invalidate();
            }
        }

        public int Value
        {
            get => _current;
            set
            {
                _current = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.Green))
            {
                float percent = (float)(_current - _minValue) / (_maxValue - _minValue);
                int progressWidth = (int)(percent * ClientRectangle.Width);

                e.Graphics.FillRectangle(brush, 0, 0, progressWidth, ClientRectangle.Height);
            }
        }
    }
}
