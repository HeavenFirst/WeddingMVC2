using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class Variant
    {
        public int VariantId { get; set; }
        public string toustmuster { get; set; }
        public string Musicion { get; set; }
        public string Decor { get; set; }
        public int CoupleID { get; set; }
    }
}