using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Diagnostics;
namespace OpenCVForms
{
    public partial class Form1 : Form
    {
        Mat image = new Mat();
        public Form1()
        {
            InitializeComponent();

            DisableButton();

        }

        private void DisableButton()
        {
            RevertButton.Enabled = false;
            GrayButton.Enabled = false;
            DilationButton.Enabled = false;
            ErosionButton.Enabled = false;
            OpenButton.Enabled = false;
            CloseButton.Enabled = false;
            GradientButton.Enabled = false;
            TopHatButton.Enabled = false;
            BlackHatButton.Enabled = false;
            HitMissButton.Enabled = false;
        }

        private void ActivateButton()
        {
            RevertButton.Enabled = true;
            GrayButton.Enabled = true;
            DilationButton.Enabled = true;
            ErosionButton.Enabled = true;
            OpenButton.Enabled = true;
            CloseButton.Enabled = true;
            GradientButton.Enabled = true;
            TopHatButton.Enabled = true;
            BlackHatButton.Enabled = true;
            HitMissButton.Enabled = true;
        }

        #region 파일 로드, 원본 표시, 회색조
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image = Cv2.ImRead(dlg.FileName);

                    pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);

                    ActivateButton();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        private void SetGrayButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(grayImage);

            grayImage.Dispose();
        }
        #endregion

        #region 모폴로지 변환
        private void DilationButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat dilationImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.Dilate(grayImage, dilationImage, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dilationImage);

            grayImage.Dispose();
            dilationImage.Dispose();
            kernel.Dispose();
        }

        private void ErosionButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat ErosoinImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.Erode(grayImage, ErosoinImage, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(ErosoinImage);

            grayImage.Dispose();
            ErosoinImage.Dispose();
            kernel.Dispose();
        }
        #endregion

        #region 모폴로지 연산
        private void OpenButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat openImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, openImage, MorphTypes.Open, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(openImage);

            grayImage.Dispose();
            openImage.Dispose();
            kernel.Dispose();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat closeImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, closeImage, MorphTypes.Close, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(closeImage);

            grayImage.Dispose();
            closeImage.Dispose();
            kernel.Dispose();
        }

        private void GradientButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat GradientImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, GradientImage, MorphTypes.Gradient, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(GradientImage);

            grayImage.Dispose();
            GradientImage.Dispose();
            kernel.Dispose();
        }

        private void TopHatButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat topHatImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, topHatImage, MorphTypes.TopHat, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(topHatImage);

            grayImage.Dispose();
            topHatImage.Dispose();
            kernel.Dispose();
        }

        private void BlackHatButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat blackHatImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, blackHatImage, MorphTypes.BlackHat, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(blackHatImage);

            grayImage.Dispose();
            blackHatImage.Dispose();
            kernel.Dispose();
        }

        private void HitMissButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat hitMissImage = new Mat();

            // 커널 메트릭스에서 0은 무시, 1은 유지를 한다.
            Mat kernel = Mat.Zeros(new OpenCvSharp.Size(7, 7), MatType.CV_8U);
            kernel[0, 7, 0, 1] = Mat.Ones(new OpenCvSharp.Size(1, 7), MatType.CV_8U);
            kernel[0, 1, 0, 7] = Mat.Ones(new OpenCvSharp.Size(7, 1), MatType.CV_8U);

            Cv2.MorphologyEx(grayImage, hitMissImage, MorphTypes.HitMiss, kernel, iterations:10);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hitMissImage);

            grayImage.Dispose();
            hitMissImage.Dispose();
            kernel.Dispose();
        }
        #endregion




    }
}
