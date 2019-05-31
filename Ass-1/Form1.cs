using System;
using System.Windows.Forms;

namespace Ass_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Assignment 1 for team members:
        /// Erica Teixeira - 200416441
        /// Diya Shrestha - 200407713
        /// Sasin C. Pradhan - 200409259
        /// Dorukhan Colak - 200423172
        /// Tram Mai -200425197
        /// Zishanali Murji - 200424007
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            ConvertNumber();
        }

        private void ConvertNumber()
        {
            string input = txtInput.Text;
            int nInput = int.Parse(input);

            txtDecimal.Text = txtInput.Text;
            convertToBinary(nInput);
            convertToHexa(nInput);
            convertToOctal(nInput);
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBinary.Clear();
            txtDecimal.Clear();
            txtInput.Clear();
            txtOctal.Clear();
            txtHexadecimal.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertToBinary(int nInput)
        {
            txtBinary.Clear();
            int i;
            int[] binarryArr = new int[100];

            for (i = 0; nInput > 0; i++)
            {
                binarryArr[i] = (nInput % 2);
                nInput = nInput / 2;
            }

            for (i = i - 1; i >= 0; i--)
            {
                txtBinary.Text = txtBinary.Text + binarryArr[i];
            }
        }

        private void convertToHexa(int nInput)
        {
            txtHexadecimal.Clear();
            int i = 0;
            decimal[] hexaArr = new decimal[100];
            decimal remainder;

            while (nInput != 0)
            {
                remainder = (nInput % 16);

                if (remainder < 10)
                    remainder += 48;
                else
                    remainder += 55;

                hexaArr[i++] = remainder;
                nInput = nInput / 16;
            }

            for (i = i - 1; i >= 0; i--)
            {
                txtHexadecimal.Text = txtHexadecimal.Text + (char)hexaArr[i];
            }
        }

        private void convertToOctal(int nInput)
        {
            txtOctal.Clear();
            int i;
            int[] octalArr = new int[100];

            for (i = 0; nInput > 0; i++)
            {
                octalArr[i] = (nInput % 8);
                nInput = nInput / 8;
            }

            for (i = i - 1; i >= 0; i--)
            {
                txtOctal.Text = txtOctal.Text + octalArr[i];
            }
        }
    }
}
