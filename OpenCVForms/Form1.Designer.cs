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
            OpenButton = new Button();
            CloseButton = new Button();
            GradientButton = new Button();
            TopHatButton = new Button();
            BlackHatButton = new Button();
            HitMissButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(17, 11);
            pictureBoxImage.Margin = new Padding(2);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(600, 342);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(878, 11);
            LoadBtn.Margin = new Padding(2);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(78, 20);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "load btn";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // RevertButton
            // 
            RevertButton.Location = new Point(878, 35);
            RevertButton.Margin = new Padding(2);
            RevertButton.Name = "RevertButton";
            RevertButton.Size = new Size(78, 20);
            RevertButton.TabIndex = 2;
            RevertButton.Text = "revert";
            RevertButton.UseVisualStyleBackColor = true;
            RevertButton.Click += RevertButton_Click;
            // 
            // GrayButton
            // 
            GrayButton.Location = new Point(878, 59);
            GrayButton.Margin = new Padding(2);
            GrayButton.Name = "GrayButton";
            GrayButton.Size = new Size(78, 20);
            GrayButton.TabIndex = 3;
            GrayButton.Text = "gray";
            GrayButton.UseVisualStyleBackColor = true;
            GrayButton.Click += SetGrayButton_Click;
            // 
            // DilationButton
            // 
            DilationButton.Location = new Point(878, 135);
            DilationButton.Margin = new Padding(2);
            DilationButton.Name = "DilationButton";
            DilationButton.Size = new Size(78, 20);
            DilationButton.TabIndex = 4;
            DilationButton.Text = "dilation";
            DilationButton.UseVisualStyleBackColor = true;
            DilationButton.Click += DilationButton_Click;
            // 
            // ErosionButton
            // 
            ErosionButton.Location = new Point(878, 159);
            ErosionButton.Margin = new Padding(2);
            ErosionButton.Name = "ErosionButton";
            ErosionButton.Size = new Size(78, 20);
            ErosionButton.TabIndex = 5;
            ErosionButton.Text = "erosion";
            ErosionButton.UseVisualStyleBackColor = true;
            ErosionButton.Click += ErosionButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(779, 135);
            OpenButton.Margin = new Padding(2);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(78, 20);
            OpenButton.TabIndex = 6;
            OpenButton.Text = "opening";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(779, 159);
            CloseButton.Margin = new Padding(2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(78, 20);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "closing";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // GradientButton
            // 
            GradientButton.Location = new Point(779, 183);
            GradientButton.Margin = new Padding(2);
            GradientButton.Name = "GradientButton";
            GradientButton.Size = new Size(78, 20);
            GradientButton.TabIndex = 8;
            GradientButton.Text = "gradient";
            GradientButton.UseVisualStyleBackColor = true;
            GradientButton.Click += GradientButton_Click;
            // 
            // TopHatButton
            // 
            TopHatButton.Location = new Point(697, 135);
            TopHatButton.Margin = new Padding(2);
            TopHatButton.Name = "TopHatButton";
            TopHatButton.Size = new Size(78, 20);
            TopHatButton.TabIndex = 9;
            TopHatButton.Text = "TopHat";
            TopHatButton.UseVisualStyleBackColor = true;
            TopHatButton.Click += TopHatButton_Click;
            // 
            // BlackHatButton
            // 
            BlackHatButton.Location = new Point(697, 159);
            BlackHatButton.Margin = new Padding(2);
            BlackHatButton.Name = "BlackHatButton";
            BlackHatButton.Size = new Size(78, 20);
            BlackHatButton.TabIndex = 10;
            BlackHatButton.Text = "BlackHat";
            BlackHatButton.UseVisualStyleBackColor = true;
            BlackHatButton.Click += BlackHatButton_Click;
            // 
            // HitMissButton
            // 
            HitMissButton.Location = new Point(697, 183);
            HitMissButton.Margin = new Padding(2);
            HitMissButton.Name = "HitMissButton";
            HitMissButton.Size = new Size(78, 20);
            HitMissButton.TabIndex = 11;
            HitMissButton.Text = "HitMiss";
            HitMissButton.UseVisualStyleBackColor = true;
            HitMissButton.Click += HitMissButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 434);
            Controls.Add(HitMissButton);
            Controls.Add(BlackHatButton);
            Controls.Add(TopHatButton);
            Controls.Add(GradientButton);
            Controls.Add(CloseButton);
            Controls.Add(OpenButton);
            Controls.Add(ErosionButton);
            Controls.Add(DilationButton);
            Controls.Add(GrayButton);
            Controls.Add(RevertButton);
            Controls.Add(LoadBtn);
            Controls.Add(pictureBoxImage);
            Margin = new Padding(2);
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
        private Button OpenButton;
        private Button CloseButton;
        private Button GradientButton;
        private Button TopHatButton;
        private Button BlackHatButton;
        private Button HitMissButton;
    }
}
