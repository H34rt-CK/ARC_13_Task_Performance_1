namespace ARC_13_Task_Performance_1
{
    public partial class User : Form
    {
        Functions functions = new Functions();
        private bool allowClose = false;
        List<Recipe> allRecipes;
        Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Form FrontPage;
        public User(Form previous)
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
            FrontPage = previous;
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
            allRecipes = functions.Read();
            listBox1.DataSource = allRecipes;
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Id";
            if (allRecipes.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Recipe selectedRecipe = allRecipes[listBox1.SelectedIndex];
                PopUpScreen popUp = new PopUpScreen(selectedRecipe, this);
                popUp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a recipe.");
            }
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                Application.Exit();
            }
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            allowClose = true;
            FrontPage.Show();
            this.Close();
        }
    }
}