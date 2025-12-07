namespace ARC_13_Task_Performance_1
{
    public partial class PopUpScreen : Form
    {
        private Recipe loadedRecipe;
        private Form parentFrm;
        public PopUpScreen(Recipe recipe, Form parent)
        {
            InitializeComponent();
            loadedRecipe = recipe;
            parentFrm = parent;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int baseFormWidth = 800;

            // Scale factor
            float scale = (float)this.Width / baseFormWidth;

            // Adjust RichTextBox font
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12 * scale, richTextBox1.Font.Style);
        }

        private void PopUpScreen_Load(object sender, EventArgs e)
        {
            label1.Text = loadedRecipe.Title;
            richTextBox1.Text = loadedRecipe.RecipeText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentFrm.Show();
            this.Close();
        }
    }
}
