// Program Written by Timothy Price, CSCE 3400, Fall 2024
using System.Diagnostics; 

public class Program {

    public static Stopwatch timer = new Stopwatch();
    static void Linear(int n) {
        timer.Start(); 
        for(int i = 0; i < n; i++) {
            // running forloop n times    
        }
        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        Console.Write("{0,5:F1}, ", micro);
        timer.Reset();
    }

     static void Squared(int n) {
        timer.Start(); 
        for(int i = 0; i < n; i++) {
            // running for loop n times
            for(int y = 0; y < n; y++){
                //running another for loop n times to make it n^2 
            }
        }
        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        Console.Write("{0,5:F1}, ", micro);
        timer.Reset();
    }

     static void SqrN(int n) {
        timer.Start(); 
        for(int i = 0; i < n; i++) {
            // running for loop n times
            for(int y = 0; y < n; y++){
                //running another for loop n times to make it n^2 
            }
        }
        for(int i = 0; i < n; i++){ 
            // running the for loop again for the plus 1
        }
        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        Console.Write("{0,5:F1}, ", micro);
        timer.Reset();
    }

    public static void Main(){
        int[] val = {500, 1200, 2000, 3500};
        
        Console.Write("O(n): \n"); 
        for(int i = 0; i < 10; i++){
            for(int y = 0; y < val.Length; y++) {
                Linear(val[y]);
            }
        
            Console.Write("\n");
        }

        Console.Write("O(n^2): \n"); 
        for(int i = 0; i < 10; i++){
            for(int y = 0; y < val.Length; y++) {
                Squared(val[y]);
            }
        
            Console.Write("\n");
        }
       
        Console.Write("O(n^2 + n): \n"); 
        for(int i = 0; i < 10; i++){
            for(int y = 0; y < val.Length; y++) {
                SqrN(val[y]);
            }
        
            Console.Write("\n");
        }
    

    }
}
