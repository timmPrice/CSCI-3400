// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

using System.Diagnostics; 

namespace pset1;

public class ComplexityAnalysis{

    public static Stopwatch timer = new Stopwatch();
   
    public decimal Nlinear(int n){       // O(n)
        timer.Restart(); 
        
        for(int i = 0; i < n; i++) {
            // running for-loop n number of times    
        }

        timer.Stop();
        decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
        return micro;
    }
   
    public decimal NSquared(int n){           // O(n²n)
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
  
    public decimal NSquaredN(int n){          // O(n² + n)
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

    public void warmUp(int n){
        timer.Reset(); 
        for(int i = 0; i < n; i++){
            // Run loop n times
            // to avoid including warmup time in measurements 
        } 
        timer.Stop(); 
    }

    public void runTime(int[] n, decimal[] values){
        for(int i = 0; i < n.Length; i++){
            values[i] = Nlinear(n[i]);
            values[i + n.Length] = NSquared(n[i]);
            values[i + n.Length * 2] = NSquaredN(n[i]);
        }
    }

    public void consoleLog(decimal[] values){
        for(int i = 0; i < values.Length; i++){
            Console.WriteLine("{0,5:F1}, ", values[i]);
        }
    }
}
            
