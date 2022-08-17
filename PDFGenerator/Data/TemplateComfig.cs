using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
