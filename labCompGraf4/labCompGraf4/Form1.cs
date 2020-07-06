using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCompGraf4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageOFD.ShowDialog() == DialogResult.OK)
            {
                string fileName = imageOFD.FileName;
                sourcePB.Image = new Bitmap(fileName);
            }
        }
        private void SaveFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (itpPB.Image != null)
            {
                if (resultSFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        itpPB.Image.Save(resultSFD.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RGBToBWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeGrey();
        }

        public void MakeGrey()
        {
            if (sourcePB.Image != null)
            {
                Bitmap source = new Bitmap(sourcePB.Image, new Size(greyPB.Width, greyPB.Height));
                Bitmap result = new Bitmap(greyPB.Width, greyPB.Height);
                for (int i = 0; i < sourcePB.Width; i++)
                    for (int j = 0; j < sourcePB.Height; j++)
                    {
                        Color color = source.GetPixel(i, j);
                        int grey = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                        result.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                    }
                greyPB.Image = new Bitmap(result);
            }
            
        }

        private void ITPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeITP();
        }

        private void ItpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MakeITP();
        }

        public void MakeITP()
        {
            int limit = (int)itpNumericUpDown.Value;
            Bitmap source = new Bitmap(greyPB.Image, new Size(itpPB.Width, itpPB.Height));
            Bitmap result = new Bitmap(itpPB.Width, itpPB.Height);
            for (int i = 0; i < greyPB.Width; i++)
                for (int j = 0; j < greyPB.Height; j++)
                {
                    Color colorSource = source.GetPixel(i, j);
                    int grey = (int)(colorSource.R * 0.3 + colorSource.G * 0.59 + colorSource.B * 0.11);
                    if (grey < limit) result.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    else result.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            itpPB.Image = new Bitmap(result);
        }
        //123
        private void ContrastMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contrastPB.Visible = false;            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            contrastPB.Visible = true;
            MakeContrast();
        }

        public void MakeContrast()
        {
            if (sourcePB.Image != null)
            {
                double[,] matr = new double[3, 3];
                matr[0, 0] = Convert.ToDouble(tb00.Text);
                matr[0, 1] = Convert.ToDouble(tb01.Text);
                matr[0, 2] = Convert.ToDouble(tb02.Text);
                matr[1, 0] = Convert.ToDouble(tb10.Text);
                matr[1, 1] = Convert.ToDouble(tb11.Text);
                matr[1, 2] = Convert.ToDouble(tb12.Text);
                matr[2, 0] = Convert.ToDouble(tb20.Text);
                matr[2, 1] = Convert.ToDouble(tb21.Text);
                matr[2, 2] = Convert.ToDouble(tb21.Text);

                double a = Convert.ToDouble(aTB.Text);
                double b = Convert.ToDouble(bTB.Text);

                double R = 0;
                double G = 0;
                double B = 0;

                Bitmap source = new Bitmap(sourcePB.Image, contrastPB.Size);
                Bitmap result = new Bitmap(contrastPB.Width, contrastPB.Height);

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        if ((i == 0) || (j == 0) || (i == source.Width - 1) || (j == source.Height - 1))
                        {
                            result.SetPixel(i, j, Color.Black);
                        }
                        else
                        {
                            R = a + b * (source.GetPixel(i - 1, j - 1).R * matr[0, 0] +
                                source.GetPixel(i - 1, j).R * matr[0, 1] + source.GetPixel(i - 1, j + 1).R * matr[0, 2] +
                                source.GetPixel(i, j - 1).R * matr[1, 0] + source.GetPixel(i, j).R * matr[1, 1] +
                                source.GetPixel(i, j + 1).R * matr[1, 2] + source.GetPixel(i + 1, j - 1).R * matr[2, 0] +
                                source.GetPixel(i + 1, j).R * matr[2, 1] + source.GetPixel(i + 1, j + 1).R * matr[2, 2]);
                            G = a + b * (source.GetPixel(i - 1, j - 1).G * matr[0, 0] +
                                source.GetPixel(i - 1, j).G * matr[0, 1] + source.GetPixel(i - 1, j + 1).G * matr[0, 2] +
                                source.GetPixel(i, j - 1).G * matr[1, 0] + source.GetPixel(i, j).G * matr[1, 1] +
                                source.GetPixel(i, j + 1).G * matr[1, 2] + source.GetPixel(i + 1, j - 1).G * matr[2, 0] +
                                source.GetPixel(i + 1, j).G * matr[2, 1] + source.GetPixel(i + 1, j + 1).G * matr[2, 2]);
                            B = a + b * (source.GetPixel(i - 1, j - 1).B * matr[0, 0] +
                                source.GetPixel(i - 1, j).B * matr[0, 1] + source.GetPixel(i - 1, j + 1).B * matr[0, 2] +
                                source.GetPixel(i, j - 1).B * matr[1, 0] + source.GetPixel(i, j).B * matr[1, 1] +
                                source.GetPixel(i, j + 1).B * matr[1, 2] + source.GetPixel(i + 1, j - 1).B * matr[2, 0] +
                                source.GetPixel(i + 1, j).B * matr[2, 1] + source.GetPixel(i + 1, j + 1).B * matr[2, 2]);
                            check(ref R); check(ref G); check(ref B);
                            result.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                        }
                    }
                }
                contrastPB.Image = result;
            }

        }
        private void check(ref double value)
        {
            if (value > 255)
                value = 255;
            else if (value < 0)
                value = 0;
        }

        
    }
}
