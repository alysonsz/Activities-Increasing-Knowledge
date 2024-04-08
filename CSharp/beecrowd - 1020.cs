using System; 

class URI {

    static void Main(string[] args) { 

        int days;
        days = int.Parse(Console.ReadLine());
        int years = days/365;
        days = days - (years*365);
        int month = days/30;
        days = days - (month*30);
        Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", years, month, days);
    }

}
