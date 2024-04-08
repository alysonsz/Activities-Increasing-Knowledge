using System; 

class URI {

    static void Main(string[] args) { 

        int interval = int.Parse(Console.ReadLine());
        for (int i = 1; i <= interval; i++){
            if (i % 2 == 1){
                Console.WriteLine(i);
            }
        }

    }

}
