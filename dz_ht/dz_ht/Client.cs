using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_ht
{
    class Client
    {
        long codeClient;
        string fullName;
        string address;
        long phoneNumber;
        public Client(long _codeClient,string _fullName,string _address,long _phoneNumber)
        {
            CodeClient = _codeClient;
            FullName = _fullName;
            Address = _address;
            PhoneNumber = _phoneNumber;
        }
        public int CountReplacement { get; set; } = 0;
        public long SumReplacement { get; set; }
        public long CodeClient
        {
            get => codeClient;
            set
            {
                if (value.ToString().Length < 6)
                {
                    codeClient = value;
                }
                else
                {
                    throw new Exception("Error value code client");
                }
            }
        }
        public string FullName
        {
            get => fullName;
            set
            {
                if(value.Split(" ").Length == 3)
                {
                    fullName = value;
                }
                else
                {
                    throw new Exception("Error value full name");
                }
            }
        }
        public string Address
        {
            get => address;
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    address = value;
                }
                else
                {
                    throw new Exception("Error value address");
                }
            }
        }
        public long PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if(value.ToString().Length == 12)
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new Exception("Error value phone number");
                }
            }
        }
    }
}
