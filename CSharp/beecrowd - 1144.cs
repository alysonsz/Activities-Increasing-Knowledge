using System; 

class URI {

    static void Main(string[] args) { 

        int number = int.Parse(Console.ReadLine());
        int i = 1;
        int n = 1;
        while(true){
            if (n == 1){ 
                Console.WriteLine("{0} {1} {2}", i, i*i, i*i*i);
                n = n + 1;
                continue;
                }
            if (n == 2){
                Console.WriteLine("{0} {1} {2}", i, (i*i) + 1, (i*i*i) + 1);
                if (i == number && n == 2){
                    break;
                }
                n = 1;
                i = i + 1;
            }
        }

    }

}
