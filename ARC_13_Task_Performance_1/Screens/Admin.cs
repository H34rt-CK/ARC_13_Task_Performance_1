using System.Drawing.Drawing2D;

namespace ARC_13_Task_Performance_1
{
    public partial class Admin : Form
    {
        bool ItemSelected = false;
        private bool allowClose = false;
        Functions f1 = new Functions();
        int id;
        private Form FrontPage;

        public Admin(Form previous)
        {
            InitializeComponent();
            FrontPage = previous;
        }

        

        private void AddButton_Click(object sender, EventArgs e)
        {
            String RecipeName = Title.Text;
            String RecipeInfo = Info.Text;
            if (RecipeName != null)
            {
                f1.Create(RecipeName, RecipeInfo);
                LoadRecipesToListBox();
                Title.Clear();
                Info.Clear();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ItemSelected == true)
            {
                f1.Delete(id);
                LoadRecipesToListBox();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String RecipeName = Title.Text;
            String RecipeInfo = Info.Text;
            if (ItemSelected == true)
            {
                f1.Update(id, RecipeName, RecipeInfo);
                LoadRecipesToListBox();
                Title.Clear();
                Info.Clear();
            }
        }

        private void RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecipeList.SelectedIndex == -1)
            {
                ItemSelected = false;
                id = 0;
                Title.Clear();
                Info.Clear();
            }
            else
            {
                Recipe selectedID = (Recipe)RecipeList.SelectedItem;
                Title.Text = selectedID.Title;
                Info.Text = selectedID.RecipeText;
                ItemSelected = true;
                id = selectedID.Id;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadRecipesToListBox();
        }

        private void LoadRecipesToListBox()
        {
            List<Recipe> recipes = f1.Read();
            RecipeList.DataSource = null;
            RecipeList.DataSource = recipes;
            RecipeList.DisplayMember = "Title";
            RecipeList.ValueMember = "Id";

            RecipeList.ClearSelected();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            RecipeList.ClearSelected();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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
