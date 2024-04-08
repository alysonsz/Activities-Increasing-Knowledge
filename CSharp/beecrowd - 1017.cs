using System; 

class URI {

    static void Main(string[] args) { 

        double hours = int.Parse(Console.ReadLine());
        double km = int.Parse(Console.ReadLine());
        double spent_fuel = (hours * km)/12;
        Console.WriteLine("{0:0.000}",spent_fuel);

    }

}
