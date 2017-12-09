using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPHistogram
{
    public partial class frmMain : Form
    {
        Int32[] btRHistogram = new Int32[256];
        Int32[] btGHistogram = new Int32[256];
        Int32[] btBHistogram = new Int32[256];

        public frmMain()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(open.FileName);
                    pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    lblWidth.Text = pictureBox.Image.Width.ToString();
                    lblHeight.Text = pictureBox.Image.Height.ToString();


                    lblStatus.Text = "Please wait...";
                    toolStripProgressBar.Value = 0;
                    toolStripProgressBar.Visible = true;
                    Application.DoEvents();

                    int j, i, intPercent;
                    //RED
                    for (j = 0; j <= 255; j++)
                    {
                        btRHistogram[j] = 0;
                        btGHistogram[j] = 0;
                        btBHistogram[j] = 0;
                    }

                    Bitmap btTemp = new Bitmap(pictureBox.Image);

                    for (i = 0; i < btTemp.Width; i++)
                    {

                        lblStatus.Text = "Please wait... ";
                        intPercent = (((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height));
                        lblStatus.Text += intPercent.ToString();
                        lblStatus.Text += "% of stage 1/2 completed.";

                        if (toolStripProgressBar.Value < 100)
                            toolStripProgressBar.Value = intPercent;

                        Application.DoEvents();

                        for (j = 0; j < btTemp.Height; j++)
                        {
                            btRHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).R)]++;
                            btGHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).G)]++;
                            btBHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).B)]++;
                        }
                    }

                    lblStatus.Text = "Histogram created successfully.";
                    toolStripProgressBar.Visible = false;

                    cmdAverage.Enabled = true;
                    cmdMedian.Enabled = true;
                    cmdLOG.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboColors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmdAverage.Enabled = false;
            cmdMedian.Enabled = false;
            cmdLOG.Enabled = false;

            lblStatus.Text = "Please wait...";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;
            Application.DoEvents();


            int j, i;
            //RED
            Bitmap btTemp = new Bitmap(pictureBox.Image);

            Point pt = new Point();
            Point pt2 = new Point();

            Pen selPen = new Pen(Color.Red); ;
            if (comboColors.SelectedIndex == 0)
                selPen = new Pen(Color.Red);
            if (comboColors.SelectedIndex == 1)
                selPen = new Pen(Color.Green);
            if (comboColors.SelectedIndex == 2)
                selPen = new Pen(Color.Blue);

            Bitmap bm = new Bitmap(300, 300);

            Graphics graphic = Graphics.FromImage(bm);

            int HistoMax = 0;

            if (comboColors.SelectedIndex == 0)
                HistoMax = FindMax(btRHistogram);
            if (comboColors.SelectedIndex == 1)
                HistoMax = FindMax(btGHistogram);
            if (comboColors.SelectedIndex == 2)
                HistoMax = FindMax(btBHistogram);

            lblValue.Text = HistoMax.ToString();

            int intRatio = 1;

            int btHi = 0, intPercent;
            for (i = 0; i < 256; i++)
            {

                if (comboColors.SelectedIndex == 0)
                    btHi = btRHistogram[i];
                if (comboColors.SelectedIndex == 1)
                    btHi = btGHistogram[i];
                if (comboColors.SelectedIndex == 2)
                    btHi = btBHistogram[i];

                pt.X = i; pt.Y = 300;
                pt2.X = i; pt2.Y = 300 - ((btHi * 300 / HistoMax) * intRatio);
                graphic.DrawLine(selPen, pt, pt2);

                lblStatus.Text = "Please wait... ";
                intPercent = ((i * 100) / 256);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% of stage 2/2 completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();
            }
            picturePreview.Image = bm;
            picturePreview.Refresh();
            lblStatus.Text = "Histogram drawing completed.";
            toolStripProgressBar.Visible = false;
            cmdAverage.Enabled = true;
            cmdMedian.Enabled = true;
            cmdLOG.Enabled = true;

        }

        private int FindMax(int[] Histogram)
        {
            int intMax = 0;
            for (int i = 0; i < 256; i++)
            {
                if (Histogram[i] > intMax)
                {
                    intMax = Histogram[i];
                    lblColor.Text = i.ToString();
                }
            }
            return intMax;
        }

        private void clearHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1, 1);
            picturePreview.Image = new Bitmap(bmp);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1, 1);
            picturePreview.Image = new Bitmap(bmp);
            pictureBox.Image = new Bitmap(bmp);
            cmdAverage.Enabled = false;
            cmdMedian.Enabled = false;
            cmdLOG.Enabled = false;

        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmpsave = new Bitmap(picturePreview.Image);
                    bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bmpsave.Dispose();
                }
                save.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //throw new ApplicationException("Failed saving image");
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void ApplyFilter(double[,] filter, int Size)
        {
            int i, j, it, jt, ni, nj, tR, tG, tB, intPercent = 0;
            tR = 0; tG = 0; tB = 0;
            i = 0; j = 0;
            double dblAlpha = 0;
            int CounterI = 0;
            int CounterJ = 0;

            int iMin = -1 * ((Convert.ToInt16(txtSize.Text) - 1) / 2);
            int iMax = (Convert.ToInt16(txtSize.Text) - 1) / 2;

            Bitmap btMain = new Bitmap(pictureBox.Image);
            Bitmap btTemp = new Bitmap(btMain.Width, btMain.Height);

            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;

            for (i = 0; i < btTemp.Width; i++)
            {
                lblStatus.Text = "Please wait... ";
                intPercent = ((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();


                for (j = 0; j < btTemp.Height; j++)
                {
                    tR = 0; tG = 0; tB = 0;
                    CounterI = 0;
                    CounterJ = 0;
                    for (it = iMin; it <= iMax; it++)
                    {
                        CounterJ = 0;
                        for (jt = iMin; jt <= iMax; jt++)
                        {
                            ni = i + it;
                            nj = j + jt;
                            if (ni < 0) ni = 0;
                            if (ni >= btTemp.Width) ni = btTemp.Width - 1;
                            if (nj < 0) nj = 0;
                            if (nj >= btTemp.Height) nj = btTemp.Height - 1;

                            dblAlpha = filter[CounterI, CounterJ];
                            //MessageBox.Show(CounterI.ToString() + " - " + CounterJ.ToString() + " - " + dblAlpha.ToString());

                            tR += Convert.ToInt32(btMain.GetPixel(ni, nj).R * dblAlpha);
                            tG += Convert.ToInt32(btMain.GetPixel(ni, nj).G * dblAlpha);
                            tB += Convert.ToInt32(btMain.GetPixel(ni, nj).B * dblAlpha);

                            CounterJ++;
                        }
                        CounterI++;
                    }

                    if (tR < 0) tR = 0;
                    if (tR > 255) tR = 255;

                    if (tG < 0) tG = 0;
                    if (tG > 255) tG = 255;

                    if (tB < 0) tB = 0;
                    if (tB > 255) tB = 255;

                    Color color = Color.FromArgb(tR, tG, tB);
                    btTemp.SetPixel(i, j, color);

                }
            }

            picturePreview.Image = btTemp;
            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePreview.Refresh();
            lblStatus.Text = "Filter applied successfully.";
            toolStripProgressBar.Visible = false;


        }
        private void ApplyMedian(int Size)
        {
            int i, j, it, jt, ni, nj, tR, tG, tB, intPercent = 0;
            tR = 0; tG = 0; tB = 0;
            i = 0; j = 0;

            int counter = 0;
            int[] SampleR = new int[100];
            int[] SampleG = new int[100];
            int[] SampleB = new int[100];

            int iMin = -1 * ((Size - 1) / 2);
            int iMax = (Size - 1) / 2;

            Bitmap btMain = new Bitmap(pictureBox.Image);
            Bitmap btTemp = new Bitmap(btMain.Width, btMain.Height);

            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;

            for (i = 0; i < btTemp.Width; i++)
            {
                lblStatus.Text = "Please wait... ";
                intPercent = ((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();


                for (j = 0; j < btTemp.Height; j++)
                {
                    tR = 0; tG = 0; tB = 0;
                    counter = 0;

                    for (it = iMin; it <= iMax; it++)
                    {
                        for (jt = iMin; jt <= iMax; jt++)
                        {
                            ni = i + it;
                            nj = j + jt;
                            if (ni < 0) ni = 0;
                            if (ni >= btTemp.Width) ni = btTemp.Width - 1;
                            if (nj < 0) nj = 0;
                            if (nj >= btTemp.Height) nj = btTemp.Height - 1;

                            SampleR[counter] = Convert.ToInt16(btMain.GetPixel(ni, nj).R);
                            SampleG[counter] = Convert.ToInt16(btMain.GetPixel(ni, nj).G);
                            SampleB[counter] = Convert.ToInt16(btMain.GetPixel(ni, nj).B);

                            counter++;
                        }
                    }

                    Array.Sort(SampleR);
                    Array.Sort(SampleG);
                    Array.Sort(SampleB);

                    tR = SampleR[(Size + 1) / 2];
                    tG = SampleG[(Size + 1) / 2];
                    tB = SampleB[(Size + 1) / 2];

                    Color color = Color.FromArgb(tR, tG, tB);
                    btTemp.SetPixel(i, j, color);

                }
            }

            picturePreview.Image = btTemp;
            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePreview.Refresh();
            lblStatus.Text = "Filter applied successfully.";
            toolStripProgressBar.Visible = false;


        }
        private void ApplyAveraging(int Size)
        {
            int i, j, it, jt, ni, nj, tR, tG, tB, intPercent = 0;
            tR = 0; tG = 0; tB = 0;
            i = 0; j = 0;

            int iMin = -1 * ((Size - 1) / 2);
            int iMax = (Size - 1) / 2;

            Bitmap btMain = new Bitmap(pictureBox.Image);
            Bitmap btTemp = new Bitmap(btMain.Width, btMain.Height);

            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;

            for (i = 0; i < btTemp.Width; i++)
            {
                lblStatus.Text = "Please wait... ";
                intPercent = ((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();


                for (j = 0; j < btTemp.Height; j++)
                {
                    tR = 0; tG = 0; tB = 0;

                    for (it = iMin; it <= iMax; it++)
                    {
                        for (jt = iMin; jt <= iMax; jt++)
                        {
                            ni = i + it;
                            nj = j + jt;
                            if (ni < 0) ni = 0;
                            if (ni >= btTemp.Width) ni = btTemp.Width - 1;
                            if (nj < 0) nj = 0;
                            if (nj >= btTemp.Height) nj = btTemp.Height - 1;

                            tR += Convert.ToInt32(btMain.GetPixel(ni, nj).R);
                            tG += Convert.ToInt32(btMain.GetPixel(ni, nj).G);
                            tB += Convert.ToInt32(btMain.GetPixel(ni, nj).B);
                        }
                    }

                    tR = tR / (Size * Size);
                    tG = tG / (Size * Size);
                    tB = tB / (Size * Size);

                    if (tR < 0) tR = 0;
                    if (tR > 255) tR = 255;

                    if (tG < 0) tG = 0;
                    if (tG > 255) tG = 255;

                    if (tB < 0) tB = 0;
                    if (tB > 255) tB = 255;

                    Color color = Color.FromArgb(tR, tG, tB);
                    btTemp.SetPixel(i, j, color);

                }
            }

            picturePreview.Image = btTemp;
            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePreview.Refresh();
            lblStatus.Text = "Filter applied successfully.";
            toolStripProgressBar.Visible = false;


        }

        private void cmdMedian_Click(object sender, EventArgs e)
        {
            ApplyMedian(Convert.ToInt16(txtSize.Text));
        }

        private double LoG(double x, double y, double sigma)
        {
            double result = 0;
            result = 1 / (Math.PI * sigma * sigma * sigma * sigma);
            result *= 1 - (((x * x) + (y * y)) / (2 * sigma * sigma));
            result *= Math.Exp(-1 * (((x * x) + (y * y)) / (2 * sigma * 2)));
            return (result);
        }

        private void cmdLOG_Click(object sender, EventArgs e)
        {
            int templateSize;
            templateSize = Convert.ToInt16(txtSize.Text);

            double[,] template = new double[10, 10];

            //= new double[templateSize][templateSize];

            for (int x = 0; x < templateSize; x++)
            {
                for (int y = 0; y < templateSize; y++)
                {
                    // Get the LoG value for this (x,y) pair
                    if (x == ((templateSize - 1) / 2) && y == ((templateSize - 1) / 2))
                        template[x, y] = (templateSize * templateSize) - 1;
                    else
                        template[x, y] = -1;

                    MessageBox.Show(x.ToString() + " - " + y.ToString() + " - " + template[x, y].ToString());
                }
            }


            ApplyFilter(template, templateSize);
        }

        private void cmdAverage_Click(object sender, EventArgs e)
        {
            ApplyAveraging(Convert.ToInt16(txtSize.Text));
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            lblSize.Text = "x " + txtSize.Text;
        }


    }
}
