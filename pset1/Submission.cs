// Program Written by Timothy Price, CSCE 3400, Fall 2024
using System.Diagnostics; 

public class Program {

    public static Stopwatch timer = new Stopwatch();
   
    public static decimal Nlinear(int n){       // O(n)
        timer.Restart(); 
        
        for(int i = 0; i < n; i++) {
            // running for-loop n number of times    
        }

        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        return micro;
    }
   
    public static decimal NSquared(int n){           // O(n²)
        timer.Restart();

        for(int i = 0; i < n; i++) {
            // running for-loop n times
            for(int y = 0; y < n; y++){
                //running a nested for-loop n times to make it n^2 
            }
        }

        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        return micro;
    }
  
    public static decimal NSquaredN(int n){          // O(n² + n)
       timer.Restart(); 
        
        for(int i = 0; i < n; i++) {
            // running for-loop n times
            for(int y = 0; y < n; y++){
                //running another for-loop n times to make it n^2 
            }
        }
        
        for(int i = 0; i < n; i++){ 
            // running the for-loop again for the plus 1
        }

        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        return micro;
    }

    public static void warmUp(int n){
        timer.Reset(); 
        for(int i = 0; i < n; i++){
            // Run loop n times
            // to avoid including warmup time in measurements 
        } 
        timer.Stop(); 
    }

    public static void runTime(int[] n, decimal[] values){
        for(int i = 0; i < n.Length; i++){
            values[i] = Nlinear(n[i]);
            values[i + n.Length] = NSquared(n[i]);
            values[i + n.Length * 2] = NSquaredN(n[i]);
        }
    }

    public static void consoleLog(decimal[] values){
        Console.WriteLine("O(n): ");
        for(int i = 0; i < values.Length; i++){
            if (i == 4 ){
                Console.WriteLine("O(n²): ");
            } else if(i == 8){
                Console.WriteLine("O(n²+n): ");
            } 
            Console.WriteLine("{0,5:F1}, ", values[i]);
        }
    }

    public static void Main(){
        
        int[] n = {500, 1200, 2000, 3500}; 
        decimal[] runTimes = new decimal[12];
        
        warmUp(50); // warp-up method to eliminate slow outlier in the beginning
        runTime(n, runTimes); 
        consoleLog(runTimes);
    }

}
