namespace CRUDUser
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
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(44, 34, 24);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(225, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 376);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(44, 34, 24);
            button2.Location = new Point(228, 176);
            button2.Name = "button2";
            button2.Size = new Size(43, 34);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(168, 124, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(111, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "SELECT";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(44, 34, 24);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 315);
            listBox1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 238, 220);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(5, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 25);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 238, 220);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(166, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 27);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(245, 238, 220);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 28);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(168, 124, 0);
            label1.Location = new Point(111, 3);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(44, 34, 24);
            button3.Location = new Point(9, 176);
            button3.Name = "button3";
            button3.Size = new Size(43, 34);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 494);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}
