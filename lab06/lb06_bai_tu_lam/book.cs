using lb06_bai_tu_lam;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb06_bai_tu_lam
{
    public class book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set;; }
        public int year { get; set; }
        public double price { get; set; }
    }
}
List<book> book = new List<book>();
{
    book.Add(new .book("de men phieu luu ky", "to hoai", "nxb kim dong", 2014, 500000));
    book.Add(new book("mat biec", "nguyen nhat anh", "nxb kim dong", 2014, 600000));
    book.Add(new book("chi dau", "nxb kim dong", "ngo tat to",2015, 800000));
    foreach(var item in book)
    {
        Console.WriteLine("" + item);


    }
}