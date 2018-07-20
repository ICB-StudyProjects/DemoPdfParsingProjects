using IronOcr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR_Console_Net_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var licenceText = File.ReadAllText(currentDir + @"\IronOcr.License.txt");
            //License.LicenseKey = licenceText;
            //bool isValidKey = License.IsValidLicense(License.LicenseKey);


            //var Ocr = new IronOcr.AutoOcr();
            //var Result = Ocr.Read(currentDir + @"./test.pdf");
            //Console.WriteLine(Result.Text);

            TestScannedPdf(currentDir);

            //WorkingWithBitmap(currentDir);
        }

        private static void WorkingWithBitmap(string currentDir)
        {
            string filePath = currentDir + @"\test-pdf-ocr.pdf";
            Image myImage = Bitmap.FromFile(filePath, true);
            Bitmap myMap = new Bitmap(100, 100);
            Graphics certGraphics = Graphics.FromImage(myMap);

            Console.WriteLine(myMap.ToString());
            //Console.WriteLine(myMap.ToString());
        }

        private static void TestScannedPdf(string currentDir)
        {
            AdvancedOcr Ocr = new AdvancedOcr()
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

            //string filePath = currentDir + @"\test-pdf-ocr.pdf";
            //Image myImage = Image.FromFile(filePath, true);

            var testDocument = currentDir + @"\test-pdf-ocr.pdf";

            Point point = new Point(71, 1278);
            Size size = new Size(1282, 90);
            Rectangle rect = new Rectangle(point, size);

            var Results = Ocr.ReadPdf(testDocument, rect, 1);
            //Results.Pages.
            var Pages = Results.Pages;
            var Barcodes = Results.Barcodes;
            var FullPdfText = Results.Text;

            
            foreach (var page in Results.Pages)
            {
                Console.WriteLine(page);
            }

            Console.WriteLine(FullPdfText);
            //Console.WriteLine("Barcodes:" + String.Join(",", Results.Barcodes.Select(b => b.Value)));
        }
    }
}
