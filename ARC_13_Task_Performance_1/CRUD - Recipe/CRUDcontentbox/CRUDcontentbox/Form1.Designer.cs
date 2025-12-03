namespace CRUDcontentbox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 34, 24);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(90, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 537);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(44, 34, 24);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(78, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(436, 404);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "Ingredients";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(44, 34, 24);
            button2.Location = new Point(20, 241);
            button2.Name = "button2";
            button2.Size = new Size(43, 34);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(44, 34, 24);
            button1.Location = new Point(529, 241);
            button1.Name = "button1";
            button1.Size = new Size(43, 34);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 253, 208);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(1, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(591, 18);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 253, 208);
            panel3.Location = new Point(-9, -15);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 4);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 253, 208);
            panel4.Location = new Point(588, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 479);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 253, 208);
            panel2.Location = new Point(1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 477);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(238, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 54);
            label1.TabIndex = 1;
            label1.Text = "Food name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(551, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(44, 34, 24);
            button3.Location = new Point(11, 26);
            button3.Name = "button3";
            button3.Size = new Size(39, 33);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(786, 626);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}
