namespace SertificatesApp
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using SertificatesApp.Utils;
    using SertificatesApp.Entities;
    using System.Text;
    using System.Collections.Generic;
    using SertificatesApp.OCR;
    using IronOcr;
    using System.Drawing;
    using System.Diagnostics;
    using System.Linq;

    public partial class MyForm : Form
    {
        private AdvancedOcr advOcr;
        private string currentCertText;
        private string certificatePath;
        private bool isPdf;
        private IDictionary<string, double> labResult = new Dictionary<string, double>();

        public MyForm()
        {
            FileContainer = new FileContainerModel();
            
            //CompareResult = new Dictionary<string, int>();

            InitializeComponent();

            advOcr = SetOcrAdvConfig();
        }

        public FileContainerModel FileContainer { get; set; }

        public IDictionary<string, int> CompareResult { get; set; }

        private AdvancedOcr SetOcrAdvConfig()
        {
            AdvancedOcr advOcr = new AdvancedOcr()
            {
                CleanBackgroundNoise = false,
                ColorDepth = 4,
                ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                EnhanceContrast = false,
                DetectWhiteTextOnDarkBackgrounds = false,
                RotateAndStraighten = false,
                Language = IronOcr.Languages.English.OcrLanguagePack,
                EnhanceResolution = false,
                InputImageType = AdvancedOcr.InputTypes.Document,
                ReadBarCodes = true,
                Strategy = AdvancedOcr.OcrStrategy.Fast
            };

            return advOcr;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSelectFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtCertificate.Text = ofdSelectFile.SafeFileName;
                
                string file = ofdSelectFile.FileName;
                certificatePath = file;
                var suffix = Path.GetExtension(file);

                if (suffix == ".pdf")
                {
                    OcrResult resultOcr = MyOcr.AdvOcr.ReadPdf(ofdSelectFile.FileName, 1);
                    var page = resultOcr.Pages[0];
                    pboxCertificate.Image = page.Image;
                    //pboxCertificate.ImageLocation = resultOcr.Pages[0].;

                    this.isPdf = true;
                }
                else
                {
                    pboxCertificate.Image = Image.FromFile(ofdSelectFile.FileName);

                    this.isPdf = false;
                }

                //DisplayLoadedImage(file);
            }
        }

        //private void DisplayLoadedImage(string file)
        //{
        //    Image fileImage = Image.FromFile(file);

        //    Bitmap flag = new Bitmap(200, 100);
        //    Graphics flagGraphics = Graphics.FromImage(fileImage);
        //    int red = 0;
        //    int white = 11;
        //    while (white <= 100)
        //    {
        //        flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
        //        flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
        //        red += 20;
        //        white += 20;
        //    }

        //    pboxCertificate.Image = flag;
        //}

        

        //private void LoadSelectedCertificateData(string certFilePath)
        //{
        //    string certificatesText;
        //    try
        //    {
        //        //certificatesText = File.ReadAllText(certFilePath);
        //        currentCertText = GetFileText(certFilePath);
        //    }
        //    catch (IOException)
        //    {
        //        throw new FieldAccessException("Could not read the certificate file.");
        //    }

        //    //FileContainer.Certificates = JsonConvert.DeserializeObject<FileContainerModel>(certificatesText).Certificates;
        //}

        //private string GetFileText(string fileFullPath)
        //{
        //    var asd = this.advOcr;
        //    OcrResult results = this.advOcr.ReadPdf(fileFullPath);

        //    string fullPdfText = results.Text;

        //    return fullPdfText;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSpecifications.DisplayMember = "Name";
            cboSpecifications.ValueMember = "Name";
            LoadCombo();

            cboLab.DisplayMember = "Name";
            cboLab.ValueMember = "Certificates";
            LoadLabCombo();

            cboCertTemplate.DisplayMember = "Name";
            cboCertTemplate.ValueMember = "Pages";
        }

        private void LoadLabCombo()
        {
            string specJsonFile = ProjectDir.Root + @"\Data\cert-templates.json";

            FileContainer.LabCertTemplates = JsonConvert
               .DeserializeObject<FileContainerModel>(File.ReadAllText(specJsonFile)).LabCertTemplates;

            cboLab.DataSource = FileContainer.LabCertTemplates;
            cboLab.SelectedIndex = 0;
        }

        private void LoadCombo()
        {
            string specJsonFile = ProjectDir.Root + @"\Data\specifications.json";

            FileContainer.Specifications = JsonConvert
                .DeserializeObject<FileContainerModel>(File.ReadAllText(specJsonFile)).Specifications;

            cboSpecifications.DataSource = FileContainer.Specifications;
            cboSpecifications.SelectedIndex = 0;
        }

        private void cboSpecifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            Specification spec = cboSpecifications.SelectedItem as Specification;

            txtSpecification.Text = spec.ToString();
        }

        private void cboCertTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company company = cboLab.SelectedItem as Company;

            cboCertTemplate.DataSource = company.Certificates;
            cboCertTemplate.SelectedIndex = 0;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            CompareCertificates();

            // txtReport.Text = "Compare data";
        }

        private void CompareCertificates()
        {
            Specification spec = cboSpecifications.SelectedItem as Specification;

            foreach (Property prop in spec.Properties)
            {
                var elemProp = this.labResult[prop.Name];

                string elementStr = $"Element {prop.Name} - ";

                if (prop.Range.Min != 0 && prop.Range.Max != 0)
                {
                    if (elemProp >= prop.Range.Min && elemProp <= prop.Range.Max)
                    {
                        txtReport.SelectionColor = Color.Green;
                    }
                    else
                    {
                        txtReport.SelectionColor = Color.Red;
                    }

                    txtReport.AppendText(elementStr + $"min: {prop.Range.Min}; " +
                            $"result: {elemProp}; max: {prop.Range.Max};" + Environment.NewLine);
                }
                else if (prop.Range.Min != 0)
                {
                    if (elemProp >= prop.Range.Min)
                    {
                        txtReport.SelectionColor = Color.Green;
                    }
                    else
                    {
                        txtReport.SelectionColor = Color.Red;
                    }

                    txtReport.AppendText(elementStr + $"min: {prop.Range.Min}; " +
                            $"result: {elemProp};" + Environment.NewLine);
                }
                else if (prop.Range.Max != 0)
                {
                    if (elemProp <= prop.Range.Max)
                    {
                        txtReport.SelectionColor = Color.Green;
                    }
                    else
                    {
                        txtReport.SelectionColor = Color.Red;
                    }

                    txtReport.AppendText(elementStr +
                            $"result: {elemProp}; max: {prop.Range.Max};" + Environment.NewLine);
                }
                else
                {
                    txtReport.SelectionColor = Color.Green;
                    txtReport.AppendText(elementStr + $"result: {elemProp};" + Environment.NewLine);
                }
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pboxCertificate.Width += 20;
            pboxCertificate.Height += 20;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pboxCertificate.Width -= 20;
            pboxCertificate.Height -= 20;
        }

        private void btnProcessOcr_Click(object sender, EventArgs e)
        {
            ProcessOcrData();
        }

        private void ProcessOcrData()
        {
            //string imgToProcessPath = pboxCertificate.ImageLocation;
            //Image imgToProcess = pboxCertificate.Image;

            Certificate certificate = cboCertTemplate.SelectedItem as Certificate;
            
            // Clear all OCR test boxes and values
            pPictureBoxes.Controls.Clear();
            txtOCRInfo.Text = "";
            pboxTotalY = 10;

            foreach (Page page in certificate.Pages)
            {
                if (page.Id > 1 && !this.isPdf)
                {
                    continue;
                }
                
                foreach (Rectangle rect in page.Coordinates)
                {
                    OcrResult resultOcr;

                    if (isPdf)
                    {
                        resultOcr = MyOcr.AdvOcr.ReadPdf(certificatePath, rect, page.Id);
                    }
                    else
                    {
                        resultOcr = MyOcr.AdvOcr.Read(certificatePath, rect);
                    }

                    VisualizeOcrInfo(resultOcr.Pages);
                }
            }
        }

        private void VisualizeOcrInfo(IList<OcrResult.OcrPage> pages)
        {
            StringBuilder sb = new StringBuilder();

            foreach (OcrResult.OcrPage page in pages)
            {
                foreach (var paragraph in page.Paragraphs)
                {
                    if (paragraph.Lines.Count == 4)
                    {
                        var elements = paragraph.Lines.FirstOrDefault().Words.Select(w => w.Text.ToUpper());
                        var labResultStrs = paragraph.Lines.Last()
                            .Words.Skip(1).Select(w => w.Text).ToList();

                        labResultStrs[6] += labResultStrs[7];
                        labResultStrs.RemoveAt(7);

                        var labResultNums = labResultStrs.Select(double.Parse).ToArray();
                        labResult = elements
                            .Select((elem, i) => new { Elem = elem, Res = labResultNums[i] })
                            .ToDictionary(o => o.Elem, o => o.Res);
                    }

                    sb.AppendLine(paragraph.Text);
                }

                PictureBox picBox = CreatePictureBox(page.Image);

                pPictureBoxes.Controls.Add(picBox);
            }
            
            sb.AppendLine("=================");
            txtOCRInfo.Text += sb.ToString();
        }

        private int pboxTotalY;

        private PictureBox CreatePictureBox(Image ocrImg)
        {
            PictureBox newPicBox = new PictureBox();

            newPicBox.Image = ocrImg;
            newPicBox.Width = pPictureBoxes.Width - 35;
            newPicBox.Height = 100;
            newPicBox.BackgroundImageLayout = ImageLayout.Center;
            newPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            newPicBox.BorderStyle = BorderStyle.FixedSingle;
            newPicBox.Location = new Point(10, pboxTotalY);
            newPicBox.Show();

            pboxTotalY += newPicBox.Height + 10;

            return newPicBox; 
        }
    }
}
