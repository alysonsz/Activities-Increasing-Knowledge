    using System; 
    
    class URI {
    
        static void Main(string[] args) { 
            double i = 0;
            double j = 1;
            int n = 0;
            while(true){
                if (n == 3){
                    break;
                }
                if (i == 0){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 1.2;
                        i = 0.2;
                        continue;
                    }
                }
                if (i == 0.2){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 1.4;
                        i = 0.4;
                        continue;
                    }
                }
                if (i == 0.4){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 1.6;
                        i = 0.6;
                        continue;
                    }
                }
                if (i == 0.6){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 1.8;
                        i = 0.8;
                        continue;
                    }
                }
                if (i == 0.8){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 2;
                        i = 1;
                        continue;
                    }
                }
                if (i == 1){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 2.2;
                        i = 1.2;
                        continue;
                    }
                }
                if (i == 1.2){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 2.4;
                        i = 1.4;
                        continue;
                    }
                }
                if (i == 1.4){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 2.6;
                        i = 1.6;
                        continue;
                    }
                }
                if (i == 1.6){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 2.8;
                        i = 1.8;
                        continue;
                    }
                }
                if (i == 1.8){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        n = 0;
                        j = 3;
                        i = 2;
                        continue;
                    }
                }
                if (i == 2){
                    n = n + 1;
                    Console.WriteLine("I={0} J={1}", i, j);
                    j = j + 1;
                    if (n == 3){
                        break;
                    }
                }
            }
        }
    }
