// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Program {
   
    public static void Main(){
        
        ComplexityAnalysis analysis = new ComplexityAnalysis(); 
        Graphing graph = new Graphing();
        
        int[] n = {500, 1200, 1500, 3000}; 
        decimal[] runTime = new decimal[12];
        decimal[] plotPoints = new decimal[4];
        
        analysis.warmUp(50); // warp-up method to eliminate slow outlier in the beginning
        analysis.runTime(n, runTime);
        analysis.consoleLog(runTime);

        graph.sketchGraph(runTime, plotPoints, n);
    } 
}


