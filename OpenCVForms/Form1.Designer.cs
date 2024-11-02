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
            laplacianFilterButton = new Button();
            cannyEdgeFilterButton = new Button();
            unsharpButton = new Button();
            gaussianBlurButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(24, 18);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(857, 570);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(1254, 18);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(111, 33);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "load btn";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // revertButton
            // 
            revertButton.Location = new Point(1254, 58);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(111, 33);
            revertButton.TabIndex = 2;
            revertButton.Text = "revert";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += RevertButton_Click;
            // 
            // grayButton
            // 
            grayButton.Location = new Point(1254, 98);
            grayButton.Name = "grayButton";
            grayButton.Size = new Size(111, 33);
            grayButton.TabIndex = 3;
            grayButton.Text = "gray";
            grayButton.UseVisualStyleBackColor = true;
            grayButton.Click += SetGrayButton_Click;
            // 
            // dilationButton
            // 
            dilationButton.Location = new Point(1254, 225);
            dilationButton.Name = "dilationButton";
            dilationButton.Size = new Size(111, 33);
            dilationButton.TabIndex = 4;
            dilationButton.Text = "dilation";
            dilationButton.UseVisualStyleBackColor = true;
            dilationButton.Click += DilationButton_Click;
            // 
            // erosionButton
            // 
            erosionButton.Location = new Point(1254, 265);
            erosionButton.Name = "erosionButton";
            erosionButton.Size = new Size(111, 33);
            erosionButton.TabIndex = 5;
            erosionButton.Text = "erosion";
            erosionButton.UseVisualStyleBackColor = true;
            erosionButton.Click += ErosionButton_Click;
            // 
            // openButton
            // 
            openButton.Location = new Point(1113, 225);
            openButton.Name = "openButton";
            openButton.Size = new Size(111, 33);
            openButton.TabIndex = 6;
            openButton.Text = "opening";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += OpenButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1113, 265);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(111, 33);
            closeButton.TabIndex = 7;
            closeButton.Text = "closing";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // gradientButton
            // 
            gradientButton.Location = new Point(1113, 305);
            gradientButton.Name = "gradientButton";
            gradientButton.Size = new Size(111, 33);
            gradientButton.TabIndex = 8;
            gradientButton.Text = "gradient";
            gradientButton.UseVisualStyleBackColor = true;
            gradientButton.Click += GradientButton_Click;
            // 
            // topHatButton
            // 
            topHatButton.Location = new Point(996, 225);
            topHatButton.Name = "topHatButton";
            topHatButton.Size = new Size(111, 33);
            topHatButton.TabIndex = 9;
            topHatButton.Text = "TopHat";
            topHatButton.UseVisualStyleBackColor = true;
            topHatButton.Click += TopHatButton_Click;
            // 
            // blackHatButton
            // 
            blackHatButton.Location = new Point(996, 265);
            blackHatButton.Name = "blackHatButton";
            blackHatButton.Size = new Size(111, 33);
            blackHatButton.TabIndex = 10;
            blackHatButton.Text = "BlackHat";
            blackHatButton.UseVisualStyleBackColor = true;
            blackHatButton.Click += BlackHatButton_Click;
            // 
            // hitMissButton
            // 
            hitMissButton.Location = new Point(996, 305);
            hitMissButton.Name = "hitMissButton";
            hitMissButton.Size = new Size(111, 33);
            hitMissButton.TabIndex = 11;
            hitMissButton.Text = "HitMiss";
            hitMissButton.UseVisualStyleBackColor = true;
            hitMissButton.Click += HitMissButton_Click;
            // 
            // sobelFilterButton
            // 
            sobelFilterButton.Location = new Point(1113, 18);
            sobelFilterButton.Name = "sobelFilterButton";
            sobelFilterButton.Size = new Size(111, 33);
            sobelFilterButton.TabIndex = 12;
            sobelFilterButton.Text = "Sobel";
            sobelFilterButton.UseVisualStyleBackColor = true;
            sobelFilterButton.Click += SobelDerivativeButton_Click;
            // 
            // scharrFilterButton
            // 
            scharrFilterButton.Location = new Point(1113, 58);
            scharrFilterButton.Name = "scharrFilterButton";
            scharrFilterButton.Size = new Size(111, 33);
            scharrFilterButton.TabIndex = 13;
            scharrFilterButton.Text = "Scharr";
            scharrFilterButton.UseVisualStyleBackColor = true;
            scharrFilterButton.Click += scharrFilterButton_Click;
            // 
            // laplacianFilterButton
            // 
            laplacianFilterButton.Location = new Point(1113, 98);
            laplacianFilterButton.Name = "laplacianFilterButton";
            laplacianFilterButton.Size = new Size(111, 33);
            laplacianFilterButton.TabIndex = 14;
            laplacianFilterButton.Text = "Laplacian";
            laplacianFilterButton.UseVisualStyleBackColor = true;
            laplacianFilterButton.Click += LaplacianFilterButton_Click;
            // 
            // cannyEdgeFilterButton
            // 
            cannyEdgeFilterButton.Location = new Point(1113, 138);
            cannyEdgeFilterButton.Name = "cannyEdgeFilterButton";
            cannyEdgeFilterButton.Size = new Size(111, 33);
            cannyEdgeFilterButton.TabIndex = 15;
            cannyEdgeFilterButton.Text = "Canny edge";
            cannyEdgeFilterButton.UseVisualStyleBackColor = true;
            cannyEdgeFilterButton.Click += cannyEdgeFilterButton_Click;
            // 
            // unsharpButton
            // 
            unsharpButton.Location = new Point(887, 137);
            unsharpButton.Name = "unsharpButton";
            unsharpButton.Size = new Size(112, 34);
            unsharpButton.TabIndex = 16;
            unsharpButton.Text = "Unsharp";
            unsharpButton.UseVisualStyleBackColor = true;
            unsharpButton.Click += unsharpButton_Click;
            // 
            // gaussianBlurButton
            // 
            gaussianBlurButton.Location = new Point(887, 97);
            gaussianBlurButton.Name = "gaussianBlurButton";
            gaussianBlurButton.Size = new Size(112, 34);
            gaussianBlurButton.TabIndex = 17;
            gaussianBlurButton.Text = "Gaussian";
            gaussianBlurButton.UseVisualStyleBackColor = true;
            gaussianBlurButton.Click += gaussianBlurButton_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 723);
            Controls.Add(gaussianBlurButton);
            Controls.Add(unsharpButton);
            Controls.Add(cannyEdgeFilterButton);
            Controls.Add(laplacianFilterButton);
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
        private Button laplacianFilterButton;
        private Button cannyEdgeFilterButton;
        private Button unsharpButton;
        private Button gaussianBlurButton;
    }
}
