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
        }

        private void ActivateButton()
        {
            RevertButton.Enabled = true;
            GrayButton.Enabled = true;
            DilationButton.Enabled = true;
            ErosionButton.Enabled = true;
        }

        #region ���� �ε�, ���� ǥ��, ȸ����
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

        #region �������� ��ȯ
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

        #region �������� ����

        #endregion
    }
}
