using System; 

class URI {
    
    static void Main(string[] args) { 
        int quantify = int.Parse(Console.ReadLine());
        double result = 0;
        for (int i = 0; i != quantify; i++){
            string[] values = Console.ReadLine().Split(' ');
            int num1 = int.Parse(values[0]);
            int num2 = int.Parse(values[1]);
            if (num2 == 0){
                Console.WriteLine("divisao impossivel");
            }
            else{
                result = (double)num1/(double)num2;
                Console.WriteLine("{0:0.0}", result);
            }
        }

    }

}
