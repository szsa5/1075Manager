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
        public string bor_evjarat { get; set; }
        public string bor_szolo { get; set; }
        public string bor_ken { get; set; }
        public string bor_alkohol { get; set; }
        public string bor_cukor { get; set; }
        public string bor_extrakt { get; set; }
        public string bor_pdatum { get; set; }
        public string bor_ar { get; set; }
        public int bor_raktar { get; set; }
        public Image Image { get; set; }

        public WineModel() 
        {
        }

        public WineModel(int id, string nameTB, string vintageTB, string grapesTB, string sulfitesTB, 
                         string alcoholTB, string sugarTB, string extractTB, string bdateTB, string price, 
                         int instock, string fullpicturepath)
        {
            bor_id = id;
            bor_nev = nameTB;
            bor_evjarat = vintageTB;
            bor_szolo = grapesTB;
            bor_ken = sulfitesTB;
            bor_alkohol = alcoholTB;
            bor_cukor = sugarTB;
            bor_extrakt = extractTB;
            bor_pdatum = bdateTB;
            bor_ar = price;
            bor_raktar = instock;
            Image = new Bitmap(fullpicturepath);
        }
    }
}
