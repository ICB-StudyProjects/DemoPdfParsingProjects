namespace SertificatesApp
{
    using IronOcr;

    public static class MyOcr
    {
        static MyOcr()
        {
            AdvOcr = SetAdvOcrConfigs();
        }

        public static AdvancedOcr AdvOcr { get; private set; }

        private static AdvancedOcr SetAdvOcrConfigs()
        {
            var advOcr = new AdvancedOcr
            {
                CleanBackgroundNoise = false,
                ColorDepth = 4,
                ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                EnhanceContrast = true,
                DetectWhiteTextOnDarkBackgrounds = true,
                RotateAndStraighten = true, // CPU/GPU intensive
                Language = IronOcr.Languages.English.OcrLanguagePack,
                EnhanceResolution = true,
                InputImageType = AdvancedOcr.InputTypes.Document,
                ReadBarCodes = false,
                Strategy = AdvancedOcr.OcrStrategy.Advanced
            };

            return advOcr;
        }
    }
}
