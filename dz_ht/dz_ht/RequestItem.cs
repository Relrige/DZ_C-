using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ht
{
    struct RequestItem
    {
        public Article Article { get; set; }
        public ushort CountProduct { get; set; }
        public RequestItem(ushort countProduct,Article article)
        {
            Article = article;
            CountProduct = countProduct;
        }
    }
}
