using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PDFGenerator.Models
{
    public class SampleModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int sample1 { get; set; }
        public int sample2 { get; set; }
        public int sample3 { get; set; }
        public int sample4 { get; set; }

    }
}
