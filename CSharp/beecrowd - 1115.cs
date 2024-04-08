using System; 

class URI {

    static void Main(string[] args) { 
        while(true){
            string[] quadrant = Console.ReadLine().Split();
            int x = int.Parse(quadrant[0]);
            int y = int.Parse(quadrant[1]);
            if (x == 0 || y == 0){
                break;
            }
            else if (x > 0 && y > 0){
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0){
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0){
                Console.WriteLine("terceiro");
            }
            else if (x > 0 && y < 0){
                Console.WriteLine("quarto");
            } 
            }
        }
}
