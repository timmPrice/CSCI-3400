// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Program {
   
    public static void Main(){
        
        ComplexityAnalysis analysis = new ComplexityAnalysis(); 
        
        // store values for graph
        int[] n = {500, 1200, 1500, 3000}; 
        decimal[] runTime = new decimal[12];
        
        // warp-up method to eliminated slow outlier in the beginning
        analysis.warmUp(50);

        // loop that runs all methods 100 times 
        // loop that runs each method 4 times for all values of n
        
        for(int i = 0; i < n.Length; i++){
            // Console.WriteLine("Runtime of { " + n[i] + " }");
            //  Console.WriteLine("{0,5:F1}, ", analysis.Nlinear(n[i]));  
            //  Console.WriteLine("{0,5:F1}, ", analysis.NSquared(n[i]));  
            //  Console.WriteLine("{0,5:F1}, ", analysis.NSquaredN(n[i]));
           
            analysis.Nlinear(n[i]);
            analysis.NSquared(n[i]);
            analysis.NSquaredN(n[i]);
        }


        decimal value = analysis.NSquaredN(n[1]);  
    } 
}


