using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> inputImage;
        private Image<Bgr, byte> bottomImage;
        private List<Image<Bgr, byte>> listOfImage;
        private List<string> listOfStrings;

        private const string INFORMATION = "Information";
        private const string WARNING = "Warning";
        private const string ERROR = "Error";
        private const string MESSAGE1 = "Скан паспорта загружен.";
        private const string MESSAGE2 = "Скан паспорта не выбран.";
        private const string MESSAGE3 = "Загрузите скан паспорта.";
        private const string MESSAGE4 = "Данные успешно распознаны.";

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox1.Image = inputImage.ToBitmap();
                MessageBox.Show(MESSAGE1, INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(MESSAGE2, WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecognizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage == null)
            {
                MessageBox.Show(MESSAGE3, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            inputImage = PassportReader.SkewCorrection(inputImage);
            inputImage = PassportReader.RemoveBackground(inputImage);
            pictureBox1.Image = inputImage.ToBitmap();
            bottomImage = PassportReader.DivideImageInHalf(inputImage)[1];
            listOfImage = PassportReader.Segmentation(bottomImage);
            listOfStrings = PassportReader.RecognizeImage(listOfImage);
            FillTextBoxs();
            MessageBox.Show(MESSAGE4, INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FillTextBoxs()
        {
            textBoxType.Text = listOfStrings[listOfStrings.Count - 3];
            textBoxCodOfIssuing.Text = listOfStrings[listOfStrings.Count - 4];
            textBoxPassportNo.Text = listOfStrings[listOfStrings.Count - 2];
            textBoxSurname.Text = listOfStrings[listOfStrings.Count - 7];
            textBoxGivenName.Text = listOfStrings[listOfStrings.Count - 9];
            textBoxNationality.Text = listOfStrings[listOfStrings.Count - 10];
            textBoxDateOfBirth.Text = listOfStrings[listOfStrings.Count - 11].Replace(" ", ".");
            textBoxIdentificationNo.Text = listOfStrings[listOfStrings.Count - 12];
            textBoxSex.Text = listOfStrings[listOfStrings.Count - 14];
            textBoxPlaceOfBirth.Text = listOfStrings[listOfStrings.Count - 15];
            textBoxDateOfIssue.Text = listOfStrings[listOfStrings.Count - 17].Replace(" ", ".");
            textBoxDateOfExpiry.Text = listOfStrings[listOfStrings.Count - 21].Replace(" ", ".");
            textBoxAuthority.Text = listOfStrings[listOfStrings.Count - 18];
            textBoxMRZ1.Text = listOfStrings[listOfStrings.Count - 22];
            textBoxMRZ2.Text = listOfStrings[listOfStrings.Count - 23];
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
