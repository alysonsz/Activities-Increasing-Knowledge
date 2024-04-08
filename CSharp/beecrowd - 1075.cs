using System; 

class URI {

    static void Main(string[] args) { 
        int number= int.Parse(Console.ReadLine());
        for (int i = 0; i < 10000; i++){
            if (i % number == 2){    
                Console.WriteLine(i);
            }
        }

    }

}
