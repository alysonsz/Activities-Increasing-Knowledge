using System;
using System.Text; 

class URI {

    static void Main(string[] args) { 
        StringBuilder sb = new StringBuilder();
        bool FirstLoop = true;
        int n = 1;
        while(n != 0){
            int num = int.Parse(Console.ReadLine());
            if (num == 0){
                n = 0;
            }
            if (!FirstLoop){
                sb.Append('\n');
            }
            for (int i = 1; i <= num; i++){
                sb.Append(i);
                if (num > i){
                    sb.Append(' ');
                }
                FirstLoop = false;
            }
        }
        Console.Write(sb);
    }
}
