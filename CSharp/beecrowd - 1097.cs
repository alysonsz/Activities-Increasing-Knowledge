    using System; 
    
    class URI {
    
        static void Main(string[] args) { 
            int i = 1;
            int j = 7;
            int n = 0;
            while(true){
                if (n == 3){
                    break;
                }
                if (i == 1){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j - 1;
                    if (n == 3){
                        n = 0;
                        j = 9;
                        i = i + 2;
                        continue;
                    }
                }
                if (i == 3){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j - 1;
                    if (n == 3){
                        n = 0;
                        j = 11;
                        i = i + 2;
                        continue;
                    }
                }
                if (i == 5){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j - 1;
                    if (n == 3){
                        n = 0;
                        j = 13;
                        i = i + 2;
                        continue;
                    }
                }
                if (i == 7){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j - 1;
                    if (n == 3){
                        n = 0;
                        j = 15;
                        i = i + 2;
                        continue;
                    }
                }
                if (i == 9){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j - 1;
                    if (n == 3){
                        break;
                    }
                }
            }
        }
    }
