using System; 

class URI {

    static void Main(string[] args) { 

        string[] value1 = Console.ReadLine().Split(' ');
        string[] value2 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(value1[0]);
        double y1 = double.Parse(value1[1]);
        double x2 = double.Parse(value2[0]);
        double y2 = double.Parse(value2[1]);
        double argument1 = (x2-x1) * (x2-x1);
        double argument2 = (y2-y1) * (y2-y1);
        double distance = Math.Sqrt(argument1+argument2);
        Console.WriteLine("{0:0.0000}",distance);
    }

}
