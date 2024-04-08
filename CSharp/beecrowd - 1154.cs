using System; 

class URI {

    static void Main(string[] args) { 
        double average = 0;
        int i = 0;
        while(true){
            int age = int.Parse(Console.ReadLine());
            if (age < 0){
                break;
            }
            average = average + age;
            i = i + 1;
        }
        average = average/i;
        Console.WriteLine("{0:0.00}", average);

    }

}
