namespace SertificatesApp.OCR
{
    using IronOcr;

    public class OCRRead
    {
        private readonly AdvancedOcr advOcr;

        public OCRRead()
        {
            this.advOcr = SetOcrAdvConfig();
        }

        public AdvancedOcr AdvOcr { get; private set; }

        public string GetFileText(string fileFullPath)
        {
            OcrResult results = this.advOcr.ReadPdf(fileFullPath);

            string fullPdfText = results.Text;

            return fullPdfText;
        }

        public string Asd()
        {
            return "";
        }

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
    }
}
