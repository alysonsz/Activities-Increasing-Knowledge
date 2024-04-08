using System; 

class URI {

    static void Main(string[] args) { 
        int result = 1;
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++){
            Console.WriteLine("{0} {1} {2} PUM", result, result + 1, result + 2);
            result = result + 4;
        }
        
    }

}
