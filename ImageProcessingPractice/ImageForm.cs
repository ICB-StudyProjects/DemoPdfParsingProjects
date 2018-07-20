namespace ImageProcessingPractice
{
    using IronOcr;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Windows.Forms;

    public partial class ImageForm : Form
    {
        private Image imgOriginal;
        private Size scaleImgSize;
        private List<Rectangle> coords;
        private bool isPdf;

        public ImageForm()
        {
            InitializeComponent();
            scaleImgSize = new Size();
            coords = new List<Rectangle>();

            SetCoords();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSelectFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnProcessImg.Visible = true;

                //pboxFileImage.ImageLocation = ofdSelectFile.FileName;
                var suffix = Path.GetExtension(ofdSelectFile.FileName);

                if (suffix == ".pdf")
                {
                    OcrResult resultOcr = MyOcr.AdvOcr.ReadPdf(ofdSelectFile.FileName, 1);
                    var page = resultOcr.Pages[0];
                    pboxFileImage.Image = page.Image;
                    imgOriginal = page.Image;
                    //pboxFileImage.ImageLocation = resultOcr.Pages[0].;

                    this.isPdf = true;
                }
                else
                {
                    pboxFileImage.Image = Image.FromFile(ofdSelectFile.FileName);

                    this.isPdf = false;
                }

                txtImage.Text = ofdSelectFile.SafeFileName;
            }
        }

        private Image Zoom(Image img, Size size, bool isTrackBar)
        {
            int newImgWidth = img.Width + size.Width;
            int newImgHeight = img.Height + size.Height;
            //if (isTrackBar)
            //{
            //    newImgWidth = (int)(img.Width * (1 + size.Width * 0.01));
            //    newImgHeight = (int)(img.Height * (1 + size.Height * 0.01));
            //}
            //else
            //{
            //    newImgWidth = img.Width + size.Width;
            //    newImgHeight = img.Height + size.Height;
            //}

            Bitmap btm = new Bitmap(img, newImgWidth, newImgHeight);

            Graphics g = Graphics.FromImage(btm);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            return btm;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            scaleImgSize.Width += 50;
            scaleImgSize.Height += 50;

            pboxOcrLines.Image = Zoom(imgOriginal, scaleImgSize, false);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            scaleImgSize.Width -= 50;
            scaleImgSize.Height -= 50;

            pboxOcrLines.Image = Zoom(imgOriginal, scaleImgSize, false);
        }

        private void pboxFileImage_Click(object sender, EventArgs e)
        {

        }

        private void ImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pboxFileImage.Image != null)
            {
                pboxFileImage.Dispose();
            }
        }

        private void tbarImageSize_Scroll(object sender, EventArgs e)
        {
            scaleImgSize.Width = imgOriginal.Width * tbarImageSize.Value / 100;
            scaleImgSize.Height = imgOriginal.Height * tbarImageSize.Value / 100;

            Debug.WriteLine(tbarImageSize.Value);

            pboxFileImage.Image = Zoom(imgOriginal, scaleImgSize, true);
        }

        private void btnProcessImg_Click(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void SetCoords()
        {
            Point point = new Point(480, 1600);
            Size size = new Size(1650, 160);
            Rectangle rect = new Rectangle(point, size);
            coords.Add(rect);

            Point point1 = new Point(480, 1910);
            Size size1 = new Size(1450, 160);
            Rectangle rect1 = new Rectangle(point1, size1);
            //Debug.WriteLine(rect1.Location);
            coords.Add(rect1);

            Point point2 = new Point(131, 1770);
            Size size2 = new Size(1350, 100);
            Rectangle rect2 = new Rectangle(point2, size2);
            coords.Add(rect2);
        }

        private void ProcessImage()
        {
            Image imgToProcessPath = pboxFileImage.Image;

            int index = 0;

            foreach (Rectangle rect in coords)
            {
                OcrResult resultOcr;

                //if (isPdf)
                //{
                //    resultOcr = MyOcr.AdvOcr.ReadPdf(imgToProcessPath, rect, 1);
                //}
                //else
                //{
                    resultOcr = MyOcr.AdvOcr.Read(imgToProcessPath, rect);
                //}

                foreach (OcrResult.OcrPage page in resultOcr.Pages)
                {
                    if (page.PageNumber > 1)
                    {
                        continue;
                    }

                    if (index == 0)
                    {
                        pboxOcrLines.Image = page.Image;

                        imgOriginal = pboxFileImage.Image;
                    }
                    else if (index == 1)
                    {
                        pboxOcrLines1.Image = page.Image;
                    }
                    else
                    {
                        pboxOcrLines2.Image = page.Image;
                    }

                    index++;
                }
            }


            

        }
    }
}
