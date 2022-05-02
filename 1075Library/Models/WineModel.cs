using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _1075Library.Models
{
    public class WineModel
    {
        public int bor_id { get; set; }
        public string bor_nev { get; set; }
        public Image Image { get; set; }
        public string bor_evjarat { get; set; }
        public string bor_szolo { get; set; }
        public string bor_ken { get; set; }
        public string bor_alkohol { get; set; }
        public string bor_cukor { get; set; }
        public string bor_extrakt { get; set; }
        public string bor_pdatum { get; set; }
        public string bor_ar { get; set; }
        public string bor_raktar { get; set; }
    }
}
