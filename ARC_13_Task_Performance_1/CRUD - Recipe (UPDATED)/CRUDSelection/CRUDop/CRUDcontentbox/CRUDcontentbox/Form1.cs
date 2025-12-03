namespace CRUDcontentbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int baseFormWidth = 800;

            // Scale factor
            float scale = (float)this.Width / baseFormWidth;

            // Adjust RichTextBox font
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12 * scale, richTextBox1.Font.Style);
        }
    }
}
