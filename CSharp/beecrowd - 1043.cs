using System; 

class URI {
    
    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split();
        double value1 = double.Parse(values[0]);
        double value2 = double.Parse(values[1]);
        double value3 = double.Parse(values[2]);
        
        if ((value1 + value2 > value3) && (value2 + value3 > value1) && (value1 + value3 > value2)){
            double perimeter = value1 + value2 + value3;
            Console.WriteLine("Perimetro = {0:0.0}", perimeter);
        }
        else{
            double area = (value3/2) * (value1 + value2);
            Console.WriteLine("Area = {0:0.0}", area);
        }
    }

}
