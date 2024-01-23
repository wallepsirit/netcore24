// See https://aka.ms/new-console-template for more information
//khai bao chung:
using lab8_3;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 0 };
string[] word = { "chi", "trich", "phe", "phan", "nguoi", "khac", "giong", "nhu", "bo", "cau", "dua", "thu", "bao", "bao", "gio", "cung", "quay", "tro", "lai", "noi", "xuat", "phat" };
List<film> film = new List<film>();
{
new film { filmid="F01",filmname="ironman",filmprice="500"},
new film { filmid="F02",filmname="spiderman",filmprice="10000"},
new film { filmid="F003",filmname="batman",filmprice="100"},
new film { filmid="F004",filmname"007",filmprice="250"},
new film { filmid = "F005", filmname = "tay du ky", filmprice = "50" }


};
//loc cac so chan:
IEnumerable<int> num = numbers.Where(n => n % 2 == 0);
show<int>(num, "loc cac so chan");
//loc cac tu co do dai >4:
IEnumerable<string> word = word.Where(w => w.Length > 4);
show<string>(word, "cac tu co 4 ky tu tro len:");
//loc cac  tu bat dau bang chu T:
IEnumerable<string> wordT = word.Where(word.dtartwith("t"));
show<string>(wordT, "cac tu bat dau bang chu t");
    

