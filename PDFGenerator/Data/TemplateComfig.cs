using System.Linq;
using System.Text;

namespace PDFGenerator.Data
{
    public class TemplateComfig
    {

        public static string GetHTMLString(DataContext _context)
        {
            var data =  _context.samplemodel.ToList();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>Company Name</th>
                                        <th>Sample1</th>
                                        <th>Sample2</th>
                                        <th>Sample3</th>
                                        <th>Sample4</th>
                                    </tr>");
            foreach (var emp in data)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                  </tr>", emp.Name, emp.CompanyName,  emp.sample1, emp.sample2, emp.sample3, emp.sample4);

            }

            sb.Append(@"<h1>Map Header</h1><br><div class=""mapouter""><div class=""gmap_canvas""><iframe width=""500"" height=""300"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=2880%20Broadway,%20New%20York&t=&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe><a href=""https://123movies-a.com""></a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=""https://www.embedgooglemap.net"">google maps create map</a><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div></div>");

            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
