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
            revertButton.Enabled = false;
            grayButton.Enabled = false;

            #region 모폴로지 연산 버튼들
            dilationButton.Enabled = false;
            erosionButton.Enabled = false;
            openButton.Enabled = false;
            closeButton.Enabled = false;
            gradientButton.Enabled = false;
            topHatButton.Enabled = false;
            blackHatButton.Enabled = false;
            hitMissButton.Enabled = false;
            #endregion

            #region 가장자리 검출 연산 버튼들
            sobelDerivativeButton.Enabled = false;
            #endregion
        }

        private void ActivateButton()
        {
            revertButton.Enabled = true;
            grayButton.Enabled = true;

            #region 모폴로지 연산 버튼들
            dilationButton.Enabled = true;
            erosionButton.Enabled = true;
            openButton.Enabled = true;
            closeButton.Enabled = true;
            gradientButton.Enabled = true;
            topHatButton.Enabled = true;
            blackHatButton.Enabled = true;
            hitMissButton.Enabled = true;
            #endregion

            #region 가장자리 검출 연산 버튼들
            sobelDerivativeButton.Enabled = true;
            #endregion
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
        }
        #endregion

        // TODO : Dispose 함수들 추가하기
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

        }
        #endregion

        #region 모폴로지 연산 함수들
        private void OpenButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat openImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, openImage, MorphTypes.Open, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(openImage);
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
        }

        private void GradientButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat closeImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, closeImage, MorphTypes.Gradient, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(closeImage);
        }

        private void TopHatButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat closeImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, closeImage, MorphTypes.TopHat, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(closeImage);
        }

        private void BlackHatButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat closeImage = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(7, 7));

            Cv2.MorphologyEx(grayImage, closeImage, MorphTypes.BlackHat, kernel);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(closeImage);
        }

        private void HitMissButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat closeImage = new Mat();

            // 커널 메트릭스에서 0은 무시, 1은 유지를 한다.
            Mat kernel = Mat.Zeros(new OpenCvSharp.Size(7, 7), MatType.CV_8U);
            kernel[0, 7, 0, 1] = Mat.Ones(new OpenCvSharp.Size(1, 7), MatType.CV_8U);
            kernel[0, 1, 0, 7] = Mat.Ones(new OpenCvSharp.Size(7, 1), MatType.CV_8U);

            Cv2.MorphologyEx(grayImage, closeImage, MorphTypes.HitMiss, kernel, iterations: 10);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(closeImage);

            kernel.Dispose();
            closeImage.Dispose();
            grayImage.Dispose();
        }
        #endregion

        #region 가장자리 검출 함수들
        private void SobelDerivativeButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(image != null);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat dst = new Mat();
            Cv2.Sobel(grayImage, dst, MatType.CV_8UC1, 1, 0);

            pictureBoxImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            dst.Dispose();
            grayImage.Dispose();
        }
        #endregion



    }
}
