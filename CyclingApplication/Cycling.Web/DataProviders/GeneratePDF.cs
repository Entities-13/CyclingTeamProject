using Cycling.Data;
using Cycling.Data.Common;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Linq;

namespace Cycling.Web.DataProviders
{
    public class GeneratePDF
    {
        public void GenerateReport(string filePath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            //XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // Create a font
            XFont font = new XFont("Verdana", 10, XFontStyle.BoldItalic);

            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                var cyclists = unitOfWork.CyclistsRepository.GetAll();

                gfx.DrawString($"The Number of Cyclists in the DB is {cyclists.Count()} !", font, XBrushes.Black,
                                             new XRect(0, 15, page.Width, page.Height),
                                          XStringFormats.TopCenter);
                gfx.DrawString($"The Cyclists Are:", font, XBrushes.Black,
                                             new XRect(0, 30, page.Width, page.Height),
                                          XStringFormats.TopCenter);
                int counter = 50;
                foreach (var cyclist in cyclists)
                {
                    gfx.DrawString($"Id-{cyclist.Id}   {cyclist.FirstName} {cyclist.LastName}  -  Age: {cyclist.Age}", font, XBrushes.Black,
                                             new XRect(0, counter, page.Width, page.Height),
                                          XStringFormats.TopCenter);
                    counter += 15;
                }
            }

            // Save the document...
            string filename = $"{filePath}Generated_PDF_Report.pdf";
            document.Save(filename);
            // ...and start a viewer.
           // Process.Start(filename);
        }
    }
}