namespace OpenCVForms
{
    partial class form1
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
            revertButton = new Button();
            grayButton = new Button();
            dilationButton = new Button();
            erosionButton = new Button();
            openButton = new Button();
            closeButton = new Button();
            gradientButton = new Button();
            topHatButton = new Button();
            blackHatButton = new Button();
            hitMissButton = new Button();
            sobelFilterButton = new Button();
            scharrFilterButton = new Button();
            LaplacianFilterButton = new Button();
            cannyEdgeFilterButton = new Button();
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
            // revertButton
            // 
            revertButton.Location = new Point(878, 35);
            revertButton.Margin = new Padding(2);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(78, 20);
            revertButton.TabIndex = 2;
            revertButton.Text = "revert";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += RevertButton_Click;
            // 
            // grayButton
            // 
            grayButton.Location = new Point(878, 59);
            grayButton.Margin = new Padding(2);
            grayButton.Name = "grayButton";
            grayButton.Size = new Size(78, 20);
            grayButton.TabIndex = 3;
            grayButton.Text = "gray";
            grayButton.UseVisualStyleBackColor = true;
            grayButton.Click += SetGrayButton_Click;
            // 
            // dilationButton
            // 
            dilationButton.Location = new Point(878, 135);
            dilationButton.Margin = new Padding(2);
            dilationButton.Name = "dilationButton";
            dilationButton.Size = new Size(78, 20);
            dilationButton.TabIndex = 4;
            dilationButton.Text = "dilation";
            dilationButton.UseVisualStyleBackColor = true;
            dilationButton.Click += DilationButton_Click;
            // 
            // erosionButton
            // 
            erosionButton.Location = new Point(878, 159);
            erosionButton.Margin = new Padding(2);
            erosionButton.Name = "erosionButton";
            erosionButton.Size = new Size(78, 20);
            erosionButton.TabIndex = 5;
            erosionButton.Text = "erosion";
            erosionButton.UseVisualStyleBackColor = true;
            erosionButton.Click += ErosionButton_Click;
            // 
            // openButton
            // 
            openButton.Location = new Point(779, 135);
            openButton.Margin = new Padding(2);
            openButton.Name = "openButton";
            openButton.Size = new Size(78, 20);
            openButton.TabIndex = 6;
            openButton.Text = "opening";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += OpenButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(779, 159);
            closeButton.Margin = new Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(78, 20);
            closeButton.TabIndex = 7;
            closeButton.Text = "closing";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // gradientButton
            // 
            gradientButton.Location = new Point(779, 183);
            gradientButton.Margin = new Padding(2);
            gradientButton.Name = "gradientButton";
            gradientButton.Size = new Size(78, 20);
            gradientButton.TabIndex = 8;
            gradientButton.Text = "gradient";
            gradientButton.UseVisualStyleBackColor = true;
            gradientButton.Click += GradientButton_Click;
            // 
            // topHatButton
            // 
            topHatButton.Location = new Point(697, 135);
            topHatButton.Margin = new Padding(2);
            topHatButton.Name = "topHatButton";
            topHatButton.Size = new Size(78, 20);
            topHatButton.TabIndex = 9;
            topHatButton.Text = "TopHat";
            topHatButton.UseVisualStyleBackColor = true;
            topHatButton.Click += TopHatButton_Click;
            // 
            // blackHatButton
            // 
            blackHatButton.Location = new Point(697, 159);
            blackHatButton.Margin = new Padding(2);
            blackHatButton.Name = "blackHatButton";
            blackHatButton.Size = new Size(78, 20);
            blackHatButton.TabIndex = 10;
            blackHatButton.Text = "BlackHat";
            blackHatButton.UseVisualStyleBackColor = true;
            blackHatButton.Click += BlackHatButton_Click;
            // 
            // hitMissButton
            // 
            hitMissButton.Location = new Point(697, 183);
            hitMissButton.Margin = new Padding(2);
            hitMissButton.Name = "hitMissButton";
            hitMissButton.Size = new Size(78, 20);
            hitMissButton.TabIndex = 11;
            hitMissButton.Text = "HitMiss";
            hitMissButton.UseVisualStyleBackColor = true;
            hitMissButton.Click += HitMissButton_Click;
            // 
            // sobelFilterButton
            // 
            sobelFilterButton.Location = new Point(779, 11);
            sobelFilterButton.Margin = new Padding(2);
            sobelFilterButton.Name = "sobelFilterButton";
            sobelFilterButton.Size = new Size(78, 20);
            sobelFilterButton.TabIndex = 12;
            sobelFilterButton.Text = "Sobel";
            sobelFilterButton.UseVisualStyleBackColor = true;
            sobelFilterButton.Click += SobelDerivativeButton_Click;
            // 
            // scharrFilterButton
            // 
            scharrFilterButton.Location = new Point(779, 35);
            scharrFilterButton.Margin = new Padding(2);
            scharrFilterButton.Name = "scharrFilterButton";
            scharrFilterButton.Size = new Size(78, 20);
            scharrFilterButton.TabIndex = 13;
            scharrFilterButton.Text = "Scharr";
            scharrFilterButton.UseVisualStyleBackColor = true;
            scharrFilterButton.Click += scharrFilterButton_Click;
            // 
            // LaplacianFilterButton
            // 
            LaplacianFilterButton.Location = new Point(779, 59);
            LaplacianFilterButton.Margin = new Padding(2);
            LaplacianFilterButton.Name = "LaplacianFilterButton";
            LaplacianFilterButton.Size = new Size(78, 20);
            LaplacianFilterButton.TabIndex = 14;
            LaplacianFilterButton.Text = "Laplacian";
            LaplacianFilterButton.UseVisualStyleBackColor = true;
            LaplacianFilterButton.Click += LaplacianFilterButton_Click;
            // 
            // cannyEdgeFilterButton
            // 
            cannyEdgeFilterButton.Location = new Point(779, 83);
            cannyEdgeFilterButton.Margin = new Padding(2);
            cannyEdgeFilterButton.Name = "cannyEdgeFilterButton";
            cannyEdgeFilterButton.Size = new Size(78, 20);
            cannyEdgeFilterButton.TabIndex = 15;
            cannyEdgeFilterButton.Text = "Canny edge";
            cannyEdgeFilterButton.UseVisualStyleBackColor = true;
            cannyEdgeFilterButton.Click += cannyEdgeFilterButton_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 434);
            Controls.Add(cannyEdgeFilterButton);
            Controls.Add(LaplacianFilterButton);
            Controls.Add(scharrFilterButton);
            Controls.Add(sobelFilterButton);
            Controls.Add(hitMissButton);
            Controls.Add(blackHatButton);
            Controls.Add(topHatButton);
            Controls.Add(gradientButton);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Controls.Add(erosionButton);
            Controls.Add(dilationButton);
            Controls.Add(grayButton);
            Controls.Add(revertButton);
            Controls.Add(LoadBtn);
            Controls.Add(pictureBoxImage);
            Margin = new Padding(2);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Button LoadBtn;
        private Button revertButton;
        private Button grayButton;
        private Button dilationButton;
        private Button erosionButton;
        private Button openButton;
        private Button closeButton;
        private Button gradientButton;
        private Button topHatButton;
        private Button blackHatButton;
        private Button hitMissButton;
        private Button sobelFilterButton;
        private Button scharrFilterButton;
        private Button LaplacianFilterButton;
        private Button cannyEdgeFilterButton;
    }
}
