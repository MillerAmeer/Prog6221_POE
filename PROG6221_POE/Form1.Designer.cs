namespace POE
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
            label1 = new Label();
            AddRecipe_button = new Button();
            Display_button = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(637, 144);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the app for \r\n             Recipes";
            // 
            // AddRecipe_button
            // 
            AddRecipe_button.BackColor = Color.MediumVioletRed;
            AddRecipe_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddRecipe_button.ForeColor = Color.White;
            AddRecipe_button.Location = new Point(45, 53);
            AddRecipe_button.Name = "AddRecipe_button";
            AddRecipe_button.Size = new Size(276, 82);
            AddRecipe_button.TabIndex = 1;
            AddRecipe_button.Text = "Add Recipe";
            AddRecipe_button.UseVisualStyleBackColor = false;
            AddRecipe_button.Click += AddRecipe_button_Click;
            // 
            // Display_button
            // 
            Display_button.BackColor = Color.Magenta;
            Display_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Display_button.ForeColor = Color.White;
            Display_button.Location = new Point(605, 53);
            Display_button.Name = "Display_button";
            Display_button.Size = new Size(276, 82);
            Display_button.TabIndex = 2;
            Display_button.Text = "Display Recipe";
            Display_button.UseVisualStyleBackColor = false;
            Display_button.Click += Display_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 413);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 187);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(AddRecipe_button);
            panel2.Controls.Add(Display_button);
            panel2.Location = new Point(0, 633);
            panel2.Name = "panel2";
            panel2.Size = new Size(919, 187);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 817);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddRecipe_button;
        private Button Display_button;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}