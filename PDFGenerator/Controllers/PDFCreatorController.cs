using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using PDFGenerator.Data;
using SelectPdf;
namespace PDFGenerator.Controllers
{
    [Route("api/pdfcreator")]
    [ApiController]
    public class PdfCreatorController : ControllerBase
    {
        private IConverter _converter;
        private readonly DataContext _context;
  
        public PdfCreatorController(IConverter converter, DataContext context)
        {
            _context = context;
            _converter = converter;
        }
        [HttpGet]
        public IActionResult CreatePDF()
        {
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.MinPageLoadTime = 5;

            /*var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = @"D:\PDFCreator\Employee_Report.pdf"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateComfig.GetHTMLString(_context),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };*/
            /*_converter.Convert(pdf);*/
            PdfDocument doc = converter.ConvertHtmlString(TemplateComfig.GetHTMLString(_context));
            doc.Save("image.pdf");
            doc.Close();
            return Ok("Successfully created PDF document.");
        }
    }
}
