using System; 

class URI {

    static void Main(string[] args) { 

        double num1 = 0, num2 = 0, num3 = 0;
        string[] values = Console.ReadLine().Split(' ');
        num1 = double.Parse(values[0]);
        num2 = double.Parse(values[1]);
        num3 = double.Parse(values[2]);	
        double bhaskara = (num2*num2) - (4 * num1 * num3);
        if((num1 == 0) || (bhaskara < 0)){
            Console.WriteLine("Impossivel calcular");
        }
        else{
            double R1 = ((num2*-1) + Math.Sqrt(bhaskara))/(2*num1);
            double R2 = ((num2*-1) - Math.Sqrt(bhaskara))/(2*num1);
            Console.WriteLine("R1 = {0:0.00000}\nR2 = {1:0.00000}", R1, R2);
        }

    }

}
