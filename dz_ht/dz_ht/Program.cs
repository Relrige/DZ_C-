using System;
using System.Collections.Generic;

namespace dz_ht
{
    class Program
    {
    static int CompareForSort(Article e ,Article e2)
    {
        return e.Type.CompareTo(e2.Type);
    }
        static void Main(string[] args)
        {
            // 1
            Client client1 = new Client(1, "Denisov Denis Denisovych", "BAnderu", 123456789123);
            Client client2 = new Client(2, "Ivanov Ivan Ivanovych", "Volunskoi", 123456789124);
            Request request1 = new Request();
            Request request2 = new Request();
            request1.Customer = client1;
            request2.Customer = client2;
            request1.Fill();
            request2.Fill();
            for (int i = 0; i < 4; i++)
            {
                string[] fullName = { "Item", "Item2", "Item3", "Item4" };
                request1.AddRequestItem(new RequestItem((ushort)new Random().Next(1, 1100), new Article((ushort)new Random().Next(1, 1100), fullName[new Random().Next(fullName.Length)], (ushort)new Random().Next(1, 1100), Article.TypeProduct.TypeSecond)));
                Console.WriteLine("Sum  request 1: " + request1.SumRequest);
                Console.WriteLine("Sum  client 1: " + client1.SumReplacement);

                Console.WriteLine("Count item  request 1: " + request1.Customer.CountReplacement);

            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                string[] fullName = { "Ivanov ivan Ivanovych", "Petrov Petro Petrovych" };

                request2.AddRequestItem(new RequestItem((ushort)new Random().Next(1, 1100), new Article((ushort)new Random().Next(1, 1100), fullName[new Random().Next(fullName.Length)], (ushort)new Random().Next(1, 1100), Article.TypeProduct.TypeSecond)));
                Console.WriteLine("Sum  request 2: " + request2.SumRequest);
                Console.WriteLine("Sum  client 2: " + client2.SumReplacement);
                Console.WriteLine("Count item  request 2: " + request2.Customer.CountReplacement);
            }

            // 2
            Article articleSecond = new Article(1254, "Product1", 92, Article.TypeProduct.TypeThird);
            Article article = new Article(235, "Product3", 381, Article.TypeProduct.TypeSecond);
            Article articleThird = new Article(1355, "Product2", 194, Article.TypeProduct.TypeFirst);

            Console.WriteLine($"Result CompareTo : {article.CompareTo(articleSecond)}");
            List<Article> articles = new List<Article>();
            articles.Add(article);
            articles.Add(articleSecond);
            articles.Add(articleThird);
            articles.Sort();
            Console.WriteLine();
            foreach (var item in articles)
            {
                Console.WriteLine("Code product : " + item.CodeProduct);
            }
            articles.Sort((e, e2) => (e.Name.CompareTo(e2.Name)));
            Console.WriteLine();
            foreach (var item in articles)
            {
                Console.WriteLine("Name product : " + item.Name);
            }
            articles.Sort(CompareForSort);
            Console.WriteLine();
            foreach (var item in articles)
            {
                Console.WriteLine("Type product : " + item.Type);
            }
            articles.Sort(new CmpPriceArticle());
            Console.WriteLine();
            foreach (var item in articles)
            {
                Console.WriteLine("Price product : " + item.Price);
            }
            //Task 3
            Client client = new Client(1, "Kulakevych Stas Vitalovych", "Avenue street 11", 380123456789);
            Request request = new Request(12, client, DateTime.Now);
            Request requestClone = (Request)request.Clone();
        }
    }
}
