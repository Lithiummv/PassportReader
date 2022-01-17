using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> inputImage;
        Image<Bgr, byte> bottomImage;
        List<Image<Bgr, byte>> listOfImage;
        List<string> listOfStrings;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox1.Image = inputImage.ToBitmap();
                MessageBox.Show("Скан паспорта загружен.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Скан паспорта не выбран.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void recognizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                inputImage = PassportReader.SkewCorrection(inputImage);
                inputImage = PassportReader.RemoveBackground(inputImage);
                pictureBox1.Image = inputImage.ToBitmap();
                bottomImage = PassportReader.DivideImageInHalf(inputImage)[1];
                listOfImage = PassportReader.Segmentation(bottomImage);
                listOfStrings = PassportReader.RecognizeImage(listOfImage);
                FillTextBoxs();
                MessageBox.Show("Данные успешно распознаны.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Загрузите скан паспорта.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
