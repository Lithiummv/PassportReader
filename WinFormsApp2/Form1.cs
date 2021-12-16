using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> inputImage;
        Image topImage;
        Image bottomImage;
        List<Image> listImage = new List<Image>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Распознавание текста
        /// </summary>
        void recognizeImag()
        {
            Tesseract tesseract = new Tesseract("D:\\test", "eng", OcrEngineMode.TesseractLstmCombined);
            List<string> str = new List<string>();
            foreach (Image img in listImage)
            {
                Bitmap bitmap = new Bitmap(img);
                Image<Bgr, byte> image = bitmap.ToImage<Bgr, byte>();
                tesseract.SetImage(image);
                tesseract.Recognize();
                str.Add(tesseract.GetUTF8Text());
            }
            textBoxType.Text = str[str.Count - 3];
            textBoxCodOfIssuing.Text = str[str.Count - 4];
            textBoxPassportNo.Text = str[str.Count - 2];
            textBoxSurname.Text = str[str.Count - 7];
            textBoxGivenName.Text = str[str.Count - 9];
            textBoxNationality.Text = str[str.Count - 10];
            textBoxDateOfBirth.Text = str[str.Count - 11].Replace(" ", ".");
            textBoxIdentificationNo.Text = str[str.Count - 12];
            textBoxSex.Text = str[str.Count - 14];
            textBoxPlaceOfBirth.Text = str[str.Count - 15];
            textBoxDateOfIssue.Text = str[str.Count - 17].Replace(" ", ".");
            textBoxDateOfExpiry.Text = str[str.Count - 21].Replace(" ", ".");
            textBoxAuthority.Text = str[str.Count - 18];
            textBoxMRZ1.Text = str[str.Count - 22];
            textBoxMRZ2.Text = str[str.Count - 23];
            tesseract.Dispose();
        }

        /// <summary>
        /// Вырезает прямоугольную область изображения
        /// </summary>
        /// <param name="srcBitmap"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        static public Image cutRectangle(Image srcBitmap, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }

            return bmp;
        }

        /// <summary>
        /// Выбор изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox1.Image = inputImage.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recognizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                string dir = "D:\\t";
                string[] files = Directory.GetFiles(dir);

                foreach (string file in files)
                {
                    File.Delete(file);
                }

                inputImage = skewCorrection(inputImage);
                inputImage = cropImag(inputImage);
                pictureBox1.Image = inputImage.ToBitmap();
                divideImageInHalf(inputImage);
                segmentation();
                recognizeImag();
            }
            else
                MessageBox.Show("Выберите картинку!");
        }

        /// <summary>
        /// Удаляет лишний фон с изображения
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Image<Bgr, byte> cropImag(Image<Bgr, byte> image)
        {
            Mat croppedImage = new Mat();
            CvInvoke.CvtColor(image, croppedImage, ColorConversion.Rgb2Gray);
            CvInvoke.Canny(croppedImage, croppedImage, 10, 100);
            Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(7, 7), new Point(-1, -1));
            CvInvoke.MorphologyEx(croppedImage, croppedImage, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Constant, new MCvScalar(1));
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            CvInvoke.FindContours(croppedImage, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            Rectangle rec = CvInvoke.BoundingRectangle(contours[0]);
            Bitmap bitmap = new Bitmap(cutRectangle(image.ToBitmap(), rec));
            return bitmap.ToImage<Bgr, byte>();
        }

        /// <summary>
        /// Сементация на строки
        /// </summary>
        void segmentation()
        {
            Tesseract tesseract = new Tesseract("D:\\test", "eng", OcrEngineMode.TesseractLstmCombined);
            Bitmap bitmap = new Bitmap(bottomImage);
            Image<Bgr, byte> image = bitmap.ToImage<Bgr, byte>();
            Mat mat = new Mat();
            CvInvoke.CvtColor(image, mat, ColorConversion.Rgb2Gray);
            CvInvoke.Canny(mat, mat, 330, 390);
            Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(12, 4), new Point(-1, -1));
            CvInvoke.MorphologyEx(mat, mat, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Constant, new MCvScalar(1));
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            int[,] hierachy = CvInvoke.FindContourTree(mat, contours, ChainApproxMethod.ChainApproxSimple);
            int index = 0;
            for (; index >= 0; index = hierachy[index, 0])
            {
                if (hierachy[index, 3] == -1)
                {
                    Rectangle rec = CvInvoke.BoundingRectangle(contours[index]);
                    rec.X -= 3;
                    rec.Y -= 3;
                    rec.Width += 5;
                    rec.Height += 5;
                    Image newImg = cutRectangle(bottomImage, rec);
                    Bitmap bitmap1 = new Bitmap(newImg);
                    Image<Bgr, byte> image1 = bitmap1.ToImage<Bgr, byte>();
                    tesseract.SetImage(image1);
                    tesseract.Recognize();
                    if (tesseract.GetUTF8Text() != "")
                    {
                        listImage.Add(newImg);
                        newImg.Save("D:\\t\\" + index + ".png");
                    }
                }
            }
            tesseract.Dispose();
        }

        /// <summary>
        /// Разделение разворота на два изображения
        /// </summary>
        /// <param name="image"></param>
        void divideImageInHalf(Image<Bgr, byte> image)
        {
            Rectangle topRec = new Rectangle(0, 0, image.Width, image.Height / 2);
            Rectangle bottomRec = new Rectangle(0, 2 * image.Width / 3, image.Width, image.Height);
            topImage = cutRectangle(image.ToBitmap(), topRec);
            bottomImage = cutRectangle(image.ToBitmap(), bottomRec);
        }

        /// <summary>
        /// Поворот входного изображения
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Image<Bgr, byte> skewCorrection(Image<Bgr, byte> image)
        {
            var SE = Mat.Ones(15, 15, DepthType.Cv8U, 1);
            var binary = image.Convert<Gray, byte>()
            .SmoothGaussian(3)
            .ThresholdBinaryInv(new Gray(150), new Gray(255))
            .MorphologyEx(MorphOp.Dilate, SE, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0))
            .Erode(1);
            var points = new VectorOfPoint();
            CvInvoke.FindNonZero(binary, points);
            var minAreaRect = CvInvoke.MinAreaRect(points);
            var rotationMatrix = new Mat(2, 3, DepthType.Cv32F, 1);
            var rotatedImage = image.CopyBlank();
            var angle = minAreaRect.Angle < 45 ? minAreaRect.Angle : minAreaRect.Angle - 90;
            CvInvoke.GetRotationMatrix2D(minAreaRect.Center, angle, 1.0, rotationMatrix);
            CvInvoke.WarpAffine(image, rotatedImage, rotationMatrix, image.Size, borderMode: BorderType.Replicate);

            return rotatedImage;
        }
    }
}
