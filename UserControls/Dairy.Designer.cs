namespace POS_FO.UserControls
{
    partial class Dairy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            milkLabel = new Label();
            dairyProductsLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // milkLabel
            // 
            milkLabel.AutoSize = true;
            milkLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            milkLabel.Location = new Point(60, 134);
            milkLabel.Name = "milkLabel";
            milkLabel.Size = new Size(40, 21);
            milkLabel.TabIndex = 0;
            milkLabel.Text = "Milk";
            milkLabel.Click += milkLabel_Click;
            // 
            // dairyProductsLabel
            // 
            dairyProductsLabel.AutoSize = true;
            dairyProductsLabel.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            dairyProductsLabel.Location = new Point(203, 21);
            dairyProductsLabel.Name = "dairyProductsLabel";
            dairyProductsLabel.Size = new Size(153, 28);
            dairyProductsLabel.TabIndex = 1;
            dairyProductsLabel.Text = "Dairy Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._634c84b4931888d1cab6e956d99f924a;
            pictureBox1.Location = new Point(25, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Dairy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(dairyProductsLabel);
            Controls.Add(milkLabel);
            Name = "Dairy";
            Size = new Size(559, 396);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label milkLabel;
        private Label dairyProductsLabel;
        private PictureBox pictureBox1;
    }
}
