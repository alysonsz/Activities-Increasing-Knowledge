using System; 

class URI {

    static void Main(string[] args) { 
        int count = 0;
        for(int i = 0; i < 6; i++){
            double number = double.Parse(Console.ReadLine());
            if ((number * -1) < 0){
                count = count + 1;
            }
        }
        Console.WriteLine("{0} valores positivos", count);

    }

}
