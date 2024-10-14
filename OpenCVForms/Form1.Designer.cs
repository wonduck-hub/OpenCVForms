namespace OpenCVForms
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
            pictureBoxImage = new PictureBox();
            LoadBtn = new Button();
            RevertButton = new Button();
            GrayButton = new Button();
            DilationButton = new Button();
            ErosionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(24, 19);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(667, 361);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(1254, 19);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(112, 34);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "load btn";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // RevertButton
            // 
            RevertButton.Location = new Point(1254, 59);
            RevertButton.Name = "RevertButton";
            RevertButton.Size = new Size(112, 34);
            RevertButton.TabIndex = 2;
            RevertButton.Text = "revert";
            RevertButton.UseVisualStyleBackColor = true;
            RevertButton.Click += RevertButton_Click;
            // 
            // GrayButton
            // 
            GrayButton.Location = new Point(1254, 99);
            GrayButton.Name = "GrayButton";
            GrayButton.Size = new Size(112, 34);
            GrayButton.TabIndex = 3;
            GrayButton.Text = "gray";
            GrayButton.UseVisualStyleBackColor = true;
            GrayButton.Click += SetGrayButton_Click;
            // 
            // DilationButton
            // 
            DilationButton.Location = new Point(1254, 225);
            DilationButton.Name = "DilationButton";
            DilationButton.Size = new Size(112, 34);
            DilationButton.TabIndex = 4;
            DilationButton.Text = "dilation";
            DilationButton.UseVisualStyleBackColor = true;
            DilationButton.Click += DilationButton_Click;
            // 
            // ErosionButton
            // 
            ErosionButton.Location = new Point(1254, 265);
            ErosionButton.Name = "ErosionButton";
            ErosionButton.Size = new Size(112, 34);
            ErosionButton.TabIndex = 5;
            ErosionButton.Text = "erosion";
            ErosionButton.UseVisualStyleBackColor = true;
            ErosionButton.Click += ErosionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 467);
            Controls.Add(ErosionButton);
            Controls.Add(DilationButton);
            Controls.Add(GrayButton);
            Controls.Add(RevertButton);
            Controls.Add(LoadBtn);
            Controls.Add(pictureBoxImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Button LoadBtn;
        private Button RevertButton;
        private Button GrayButton;
        private Button DilationButton;
        private Button ErosionButton;
    }
}
