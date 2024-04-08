using System; 

class URI {

    static void Main(string[] args) { 

        int quantify = int.Parse(Console.ReadLine());
        double average = 0;
        for (int i = 0; i < quantify; i++){
            string[] values = Console.ReadLine().Split(' ');
            double value1 = double.Parse(values[0]);
            double value2 = double.Parse(values[1]);
            double value3 = double.Parse(values[2]);
            average = (value1*2 + value2*3 + value3*5)/(2+3+5);
            Console.WriteLine("{0:0.0}", average);
        }

    }

}
