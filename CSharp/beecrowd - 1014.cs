using System; 

class URI {

    static void Main(string[] args) { 

        int distance;
        distance = int.Parse(Console.ReadLine());
        float spent_fuel;
        spent_fuel = float.Parse(Console.ReadLine());
        double result;
        result = distance/spent_fuel;
        Console.WriteLine("{0:0.000} km/l",result);

    }

}
