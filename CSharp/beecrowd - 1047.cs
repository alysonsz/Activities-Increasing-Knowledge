using System; 

class URI {

    static void Main(string[] args) { 
        string[] values = Console.ReadLine().Split();
        int hour_start = int.Parse(values[0]);
        int minute_start = int.Parse(values[1]);
        int hour_end = int.Parse(values[2]);
        int minute_end = int.Parse(values[3]);
        int conversion1 = 0;
        int conversion2 = 0;
        int hour = 0;
        int minute = 0;
        
        if (hour_end <= hour_start && minute_end <= minute_start){
            hour_end = hour_end + 24;
        }
        else if (minute_end <= minute_start){
            minute_end = minute_end + 60;
            hour_end = hour_end - 1;
        }
        conversion1 = (hour_start*3600) + (minute_start*60);
        conversion2 = (hour_end*3600) + (minute_end*60);
        hour = (conversion2 - conversion1)/3600;
        minute = ((conversion2 - conversion1) - (hour * 3600))/60;
        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hour, minute);
    }

}
