using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ht
{
    struct Article :IComparable
    {
        public enum TypeProduct
        {
            TypeFirst,
            TypeSecond,
            TypeThird
        }

        uint codeProduct;
        string name;
        int price;
        TypeProduct type;
         public Article(uint _codeProduct,string _name = "",int _price = 1,TypeProduct _type = TypeProduct.TypeFirst)
        {
            codeProduct = 0;
            name = "";
            price = 0;
            type = 0;
            CodeProduct = _codeProduct;
            Name = _name;
            Price = _price;
            Type = _type;

        }
        public uint CodeProduct
        {
            get => codeProduct;
            set
            {
                if (value.ToString().Length < 6 && value.ToString().Length > 0)
                {
                    codeProduct = value;
                }
                else
                {
                    throw new Exception("Error value code");
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Error value name");
                }
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Error value price");
                }
            }
        }
        public TypeProduct Type
        {
            get => type;
            set
            {
                if(Enum.IsDefined(value))
                {
                    type = value;
                }
                else
                {
                    throw new Exception("Error value type");
                }
            }
        }

        public int CompareTo(object obj)
        {
            if(obj is Article)
            {
                Article temp = (Article)obj;
                return this.CodeProduct.CompareTo(temp.CodeProduct);
            }
            else
            {
                throw new Exception("object is not a Article");
            }
        }
    }
    class CmpPriceArticle : IComparer<Article>
    {
        public int Compare(Article x, Article y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
