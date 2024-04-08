using System; 

class URI {

    static void Main(string[] args) { 
        int highest = 0;
        int position = 0;
        for (int i = 1; i <= 100; i++){
            int num = int.Parse(Console.ReadLine());
            if (highest < num){
                highest = num;
                position = i;
            }
        }
        Console.WriteLine("{0}\n{1}", highest, position);

    }

}
