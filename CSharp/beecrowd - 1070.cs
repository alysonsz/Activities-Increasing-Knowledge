using System; 

class URI {

    static void Main(string[] args) { 
        int value = int.Parse(Console.ReadLine());
        int count = 0;
        while(count < 6){
            if (value % 2 == 1){
                Console.WriteLine(value);
                count = count + 1;
            }
            value = value + 1;
        }

    }

}
