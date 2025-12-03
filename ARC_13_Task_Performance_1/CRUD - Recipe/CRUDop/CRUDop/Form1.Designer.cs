namespace CRUDop
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            listNotes = new ListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 34, 24);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 34, 24);
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(56, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 2;
            label1.Text = "NoteIt";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(44, 34, 24);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(listNotes);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 527);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 56);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 34, 24);
            button1.Font = new Font("Stencil", 11F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-9, -22);
            button1.Name = "button1";
            button1.Size = new Size(213, 90);
            button1.TabIndex = 2;
            button1.Text = "Saved Notes";
            button1.UseVisualStyleBackColor = false;
            // 
            // listNotes
            // 
            listNotes.BackColor = Color.FromArgb(60, 50, 40);
            listNotes.BorderStyle = BorderStyle.None;
            listNotes.ForeColor = Color.White;
            listNotes.FormattingEnabled = true;
            listNotes.ItemHeight = 15;
            listNotes.Location = new Point(3, 65);
            listNotes.Name = "listNotes";
            listNotes.Size = new Size(201, 405);
            listNotes.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 2;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(256, 206);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(652, 260);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(168, 124, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 16F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(286, 492);
            button3.Name = "button3";
            button3.Size = new Size(121, 32);
            button3.TabIndex = 6;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(753, 492);
            button4.Name = "button4";
            button4.Size = new Size(120, 32);
            button4.TabIndex = 7;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(168, 124, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(438, 492);
            button5.Name = "button5";
            button5.Size = new Size(121, 32);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 34, 24);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(256, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 38);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(233, 11);
            label3.Name = "label3";
            label3.Size = new Size(163, 18);
            label3.TabIndex = 3;
            label3.Text = "CONTENT / RECIPE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(168, 124, 0);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(489, 500);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 15);
            panel4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(965, 569);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox listNotes;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
    }
}
