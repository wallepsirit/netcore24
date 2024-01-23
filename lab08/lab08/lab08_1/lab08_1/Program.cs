namespace lab08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "to", "ve", "hon", "nguoi", "thi", "thi", "nguoi", "se", "tro", "thanh", "ke", "thu", "cua", "ta", "chiu", "nhuong", "nguoi", "thi", "nguoi", "se", "thanh", "ban", "cua", "ta" };
            //truy van du lieu:
            Inumerable<string> result1 = from m in data select m;
            //hien thi ket qua:
            Console.WriteLine("hien thi tat ca ket qua:");
            foreach(var item in result1)
            {
                Console.WriteLine(item + "");
            }
            //truy van theo dieu kien lay cac tu nguoi:
            IAsyncEnumerable<string> result2=from m in data wherem.equals("nguoi");
                select m;
            //hien thi tketqua:
            Console.WriteLine("ketqua truy van theo dieu kien:");
            foreach (var item in result2)
            {
                Console.WriteLine(item + "");
            }
            //sap xep du lieu:
            IAsyncEnumerable<string> result3 = from m orderby m select m;
            //hienthi ket qua:
            Console.WriteLine("hien thi ket qua sau khi sap xep:");
            foreach (var item in result3)
            {
                Console.WriteLine(item + "");
            }
            //lay tap du lieu moi:
            var result4 = from m in data select new { thuong = m.ToLower(), hoa = m.ToUpper() };
            //hien thi ket qua:
            Console.WriteLine("in ra chu thuong va hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.thuong + ":" + item.hoa);
            }


                




        }
    }
}
