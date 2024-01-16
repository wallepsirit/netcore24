namespace lab_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> listEM = new SortedList<string, string>();
            {
                listEM.Add("E01", "tran van A");
                    listEM.Add("E02", "nguyen van b");
                listEM.Add("e3", "nguyen thi c");

                listEM.Add"E04", "mai van e") ;
                listEM.Add("E05", "le van f");
                foreach(var key in listEM.Keys)
                {
                    Console.writelines("key+" + listEM[key]);


                }

            }
        }
    }
}
