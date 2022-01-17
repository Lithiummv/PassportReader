using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Collections.Generic;
using System.Drawing;

namespace WinFormsApp2
{
    class PassportReader
    {
        static string path = "..\\..\\..\\..\\trainedData";

        public static Image<Bgr, byte> SkewCorrection(Image<Bgr, byte> image)
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

        public static Image<Bgr, byte> RemoveBackground(Image<Bgr, byte> image)
        {
            var croppedImage = new Mat();
            CvInvoke.CvtColor(image, croppedImage, ColorConversion.Rgb2Gray);
            CvInvoke.Canny(croppedImage, croppedImage, 10, 100);
            var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(7, 7), new Point(-1, -1));
            CvInvoke.MorphologyEx(croppedImage, croppedImage, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Constant, new MCvScalar(1));
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(croppedImage, contours, new Mat(), RetrType.External, ChainApproxMethod.ChainApproxSimple);
            var rect = CvInvoke.BoundingRectangle(contours[0]);

            return (CutRectangle(image, rect));
        }

        public static Image<Bgr, byte> CutRectangle(Image<Bgr, byte> image, Rectangle rect)
        {
            var bmp = new Bitmap(rect.Width, rect.Height);

            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(image.ToBitmap(), 0, 0, rect, GraphicsUnit.Pixel);
            }

            return bmp.ToImage<Bgr, byte>();
        }

        public static List<Image<Bgr, byte>> DivideImageInHalf(Image<Bgr, byte> image)
        {
            var listOfImages = new List<Image<Bgr, byte>>();
            var topRect = new Rectangle(0, 0, image.Width, image.Height / 2);
            var bottomRect = new Rectangle(0, 2 * image.Width / 3, image.Width, image.Height);
            listOfImages.Add(CutRectangle(image, topRect));
            listOfImages.Add(CutRectangle(image, bottomRect));

            return listOfImages;
        }

        public static List<Image<Bgr, byte>> Segmentation(Image<Bgr, byte> image)
        {
            var listOfImages = new List<Image<Bgr, byte>>();
            var tesseract = new Tesseract(path, "eng", OcrEngineMode.TesseractLstmCombined);
            var segmentedImage = new Mat();
            CvInvoke.CvtColor(image, segmentedImage, ColorConversion.Rgb2Gray);
            CvInvoke.Canny(segmentedImage, segmentedImage, 330, 390);
            var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(12, 4), new Point(-1, -1));
            CvInvoke.MorphologyEx(segmentedImage, segmentedImage, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Constant, new MCvScalar(1));
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            var hierachy = CvInvoke.FindContourTree(segmentedImage, contours, ChainApproxMethod.ChainApproxSimple);
            var index = 0;

            for (; index >= 0; index = hierachy[index, 0])
            {
                if (hierachy[index, 3] == -1)
                {
                    var rect = CvInvoke.BoundingRectangle(contours[index]);
                    rect.X -= 3;
                    rect.Y -= 3;
                    rect.Width += 5;
                    rect.Height += 5;
                    Image<Bgr, byte> newImage = CutRectangle(image, rect);
                    tesseract.SetImage(newImage);
                    tesseract.Recognize();
                    if (tesseract.GetUTF8Text() != "")
                    {
                        listOfImages.Add(newImage);
                    }
                }
            }

            tesseract.Dispose();

            return listOfImages;
        }

        public static List<string> RecognizeImage(List<Image<Bgr, byte>> listOfImages)
        {
            var tesseract = new Tesseract(path, "eng", OcrEngineMode.TesseractLstmCombined);
            var listOfStrings = new List<string>();

            foreach (var image in listOfImages)
            {
                tesseract.SetImage(image);
                tesseract.Recognize();
                listOfStrings.Add(tesseract.GetUTF8Text());
            }
            tesseract.Dispose();

            return listOfStrings;
        }
    }
}
