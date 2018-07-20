namespace DocParserTest
{
    using DocParserTest.Common;
    using DocParserTest.Core;
    using DocParserTest.Models;
    using Microsoft.Win32;
    using System;
    using System.Diagnostics;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IFileManager fileManager;
        private IRequestManager requestManager;
        private OpenFileDialog ofdSelectFile;

        public MainWindow()
        {
            InitializeComponent();

            ofdSelectFile = new OpenFileDialog();

            // TODO: ADD DI
            fileManager = new FileManager();
            requestManager = new RequestManager();

            BindComboBox();
        }

        private async void BindComboBox()
        {
            cboLabParsers.DisplayMemberPath = "Label";
            cboLabParsers.SelectedValuePath = "Id";

            cboLabParsers.ItemsSource = await requestManager.GetParsersRequest();
            cboLabParsers.SelectedIndex = 0;
        }

        private void btnSelectCert_Click(object sender, RoutedEventArgs e)
        {
            SelectFile(Constants.CERTIFICATE);
        }
        private void btnSelectSpec_Click(object sender, RoutedEventArgs e)
        {
            SelectFile(Constants.SPECIFICATION);
        }

        private void SelectFile(string type)
        {
            ofdSelectFile.Title = "Select a file";
            ofdSelectFile.Filter = "PDF Files (*.pdf)|*.pdf|JPEG Files (*.jpeg)|*.jpeg|TIFF Files (*.tiff)|*.tiff";

            var result = ofdSelectFile.ShowDialog();

            if (result == false)
            {
                return;
            }

            if (type == Constants.CERTIFICATE)
            {
                this.fileManager.AddFileType(Constants.CERTIFICATE, txtSelectCert.Text, ofdSelectFile.FileName);

                txtSelectCert.Text = ofdSelectFile.SafeFileName;
            }
            else if (type == Constants.SPECIFICATION)
            {
                this.fileManager.AddFileType(Constants.SPECIFICATION, txtSelectSpec.Text, ofdSelectFile.FileName);
                
                txtSelectSpec.Text = ofdSelectFile.SafeFileName;
            }
        }

        private void btnSendData_Click(object sender, RoutedEventArgs e)
        {
            Parser parserCert = cboLabParsers.SelectedItem as Parser;

            //this.requestManager.UploadFileByStream(defaultSpecParser, this.fileManager.SpecBase64);
            this.requestManager.UploadFileByStream(parserCert.Id, this.fileManager.CertBase64);
        }
    }
}
