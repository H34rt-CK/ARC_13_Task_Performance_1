namespace CRUDUser
{
    public partial class Form1 : Form
    {
        Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
        }

        Size originalPanelSize;
        float originalFormWidth;
        float originalFormHeight;

        private void Form1_Load(object sender, EventArgs e)
        {
            originalPanelSize = panel1.Size;
            originalFormWidth = this.ClientSize.Width;
            originalFormHeight = this.ClientSize.Height;

            foreach (Control ctl in panel1.Controls)
            {
                originalControlBounds[ctl] = ctl.Bounds;
            }

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.ClientSize.Width / originalFormWidth;
            float scaleY = (float)this.ClientSize.Height / originalFormHeight;
            float scale = Math.Min(scaleX, scaleY);

            panel1.Width = (int)(originalPanelSize.Width * scale);
            panel1.Height = (int)(originalPanelSize.Height * scale);
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            foreach (Control ctl in panel1.Controls)
            {
                Rectangle r = originalControlBounds[ctl];
                ctl.Left = (int)(r.Left * scale);
                ctl.Top = (int)(r.Top * scale);
                ctl.Width = (int)(r.Width * scale);
                ctl.Height = (int)(r.Height * scale);

                ctl.Font = new Font(ctl.Font.FontFamily, r.Height * 0.3f * scale, ctl.Font.Style);
            }
        }
    }
}