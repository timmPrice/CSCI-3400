// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Program {
   
    public static void Main(){
        
        ComplexityAnalysis analysis = new ComplexityAnalysis(); 
        int[] n = {500, 1200, 1500, 3000}; 

        // warp-up method to eliminated slow outlier in the beginning

        int y = 0;
        while(y < 100){
            for(int i = 0; i < n.Length; i++) {
                Console.Write("{0,5:F1}, ", analysis.Nlinear(n[i]));    // O(n)
                Console.Write("{0,5:F1}, ", analysis.NSquared(n[i]));   // O(n²)
                Console.Write("{0,5:F1}, ", analysis.NSquaredN(n[i]));  // O(n² + n)
            }
            Console.Write("\n");
            y++;
        } 
    } 
}


