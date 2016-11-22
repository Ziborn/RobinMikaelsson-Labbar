using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Klass_Obj_Arv_Poly.Classes
{
    class Magazine : Publication
    {
        new Author Author = new Author();
        public string Genre { get; set; }
        public int Pages { get; set; }
    }
}
