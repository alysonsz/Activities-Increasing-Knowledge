using System; 

class URI {

    static void Main(string[] args) { 

        int hours = 0, min = 0, convertSec = 0;
        convertSec = int.Parse(Console.ReadLine());
        hours = convertSec/3600;
        convertSec = convertSec - (hours*3600);
        min = convertSec/60;
        convertSec = convertSec - (min*60);
        
        Console.WriteLine("{0}:{1}:{2}", hours, min, convertSec);
    }

}
