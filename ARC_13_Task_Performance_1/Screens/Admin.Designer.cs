namespace ARC_13_Task_Performance_1
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            ReturnButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Title = new TextBox();
            label2 = new Label();
            Info = new RichTextBox();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            RecipeList = new ListBox();
            label4 = new Label();
            ReadButton = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 34, 24);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(ReturnButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 30, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 42);
            panel1.TabIndex = 0;
            // 
            // ReturnButton
            // 
            ReturnButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReturnButton.BackColor = Color.FromArgb(168, 124, 0);
            ReturnButton.FlatStyle = FlatStyle.Flat;
            ReturnButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnButton.ForeColor = Color.Black;
            ReturnButton.Location = new Point(915, 4);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(38, 34);
            ReturnButton.TabIndex = 13;
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 34, 24);
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(56, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 2;
            label1.Text = "KitchenNotes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(44, 34, 24);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.Location = new Point(305, 104);
            Title.Name = "Title";
            Title.Size = new Size(163, 23);
            Title.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 108);
            label2.Name = "label2";
            label2.Size = new Size(43, 14);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // Info
            // 
            Info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Info.Location = new Point(256, 206);
            Info.Name = "Info";
            Info.Size = new Size(652, 260);
            Info.TabIndex = 4;
            Info.Text = "";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.BackColor = Color.FromArgb(168, 124, 0);
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Stencil", 16F);
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(270, 492);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(121, 32);
            AddButton.TabIndex = 6;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.BackColor = Color.Maroon;
            DeleteButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(753, 492);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 32);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateButton.BackColor = Color.FromArgb(168, 124, 0);
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Location = new Point(418, 492);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(121, 32);
            UpdateButton.TabIndex = 8;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(44, 34, 24);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(256, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 38);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(233, 11);
            label3.Name = "label3";
            label3.Size = new Size(163, 18);
            label3.TabIndex = 3;
            label3.Text = "CONTENT / RECIPE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.FromArgb(168, 124, 0);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(469, 500);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 15);
            panel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 34, 24);
            panel2.Controls.Add(RecipeList);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 527);
            panel2.TabIndex = 11;
            // 
            // RecipeList
            // 
            RecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RecipeList.BackColor = Color.FromArgb(90, 65, 50);
            RecipeList.BorderStyle = BorderStyle.None;
            RecipeList.ForeColor = SystemColors.Window;
            RecipeList.FormattingEnabled = true;
            RecipeList.ItemHeight = 15;
            RecipeList.Location = new Point(0, 58);
            RecipeList.Name = "RecipeList";
            RecipeList.Size = new Size(200, 405);
            RecipeList.TabIndex = 1;
            RecipeList.SelectedIndexChanged += RecipeList_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 17);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 0;
            label4.Text = "Saved Notes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReadButton
            // 
            ReadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReadButton.BackColor = Color.FromArgb(168, 124, 0);
            ReadButton.FlatStyle = FlatStyle.Flat;
            ReadButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReadButton.ForeColor = Color.Black;
            ReadButton.Location = new Point(565, 492);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(121, 32);
            ReadButton.TabIndex = 12;
            ReadButton.Text = "Clear Screen";
            ReadButton.UseVisualStyleBackColor = false;
            ReadButton.Click += ReadButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(168, 124, 0);
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(924, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 18);
            panel5.TabIndex = 4;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(965, 569);
            Controls.Add(ReadButton);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(Info);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "KitchenNotes";
            FormClosing += Admin_FormClosing;
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Title;
        private Label label2;
        private RichTextBox Info;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Panel panel2;
        private Label label4;
        private ListBox RecipeList;
        private Button ReadButton;
        private Button ReturnButton;
        private Panel panel5;
    }
}
