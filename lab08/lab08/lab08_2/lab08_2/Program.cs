namespace lab08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//khoi tao customer
            var cus = new customer[]
            {
                new customer{cusid=5,cusname="tung"},
                new customer{cusid=6,cusname="cuc"},
                new customer{cusid=7,cusname"truc"},
                new customer{cusid=8,cusname="mai"}

            };
            //khoi tao order:
            var order = new order[]
            {
                new order{orderid=1,product="computer"},
                new order{orderid=2,product="book"},
                new order{orderid=3,product="shirt"},
                new order{orderid=4,product="games"}
            };
            //su dung truy van va join 2 tap dua tren id:
            var querry = from c in customer join o in order on c.cusid equals o.orderid
                         select new { c.cusname, o.product };
            //hien thi ten khach hang va nhom san pham:
            Console.WriteLine("khach hang va san pham:");
            foreach (var group in querry)
            {
                Console.WriteLine({ 0} bought{ 1}",group.cusname,group.product );
            }
            }
                       
        }
    }
}
