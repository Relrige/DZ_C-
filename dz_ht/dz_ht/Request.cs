using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ht
{
    class Request : ICloneable
    {
        uint codeRequest;
        Client client;
        DateTime date;
        List<RequestItem> requestItems = new List<RequestItem>();
        public Request(){}
        public Request(uint _codeRequest, Client _client,DateTime _date)
        {
            CodeRequest = _codeRequest;
            Customer = _client;
            Date = _date;
        }
        public uint CodeRequest
        {
            get => codeRequest;
            set
            {
                if (value.ToString().Length < 6)
                {
                    codeRequest = value;
                }
                else
                {
                    throw new Exception("Error value code client");
                }
            }
        }
        public void AddRequestItem(RequestItem item)
        {
            requestItems.Add(item);
            unchecked
            {
                Customer.CountReplacement = Customer.CountReplacement+1;
                Customer.SumReplacement += item.Article.Price;
            }
        }

        public object Clone()
        {
            return new Request(this.CodeRequest,this.Customer,this.Date);
        }

        public Client Customer
        {
            get => client;
            set
            {
                if(value != null)
                {
                    client = value;
                }
                else
                {
                    throw new Exception("Error value customer");
                }
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                if(value <= DateTime.Now)
                {
                    date = value;
                }else
                {
                    throw new Exception("Error value date");
                }
            }
        }
        public int SumRequest
        {
            get
            {
                return requestItems.Sum(e => e.Article.Price);
            }
        }
        public void Fill()
        {
            string[] fullName = { "Ivanov ivan Ivanovych", "Denisov Denis Denisovych" };
            this.CodeRequest = (uint)new Random().Next(1,1100);
        }


    }
}
