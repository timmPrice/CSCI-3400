// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Graphing {

    // diving the values in the array into a smaller array that can be graphed individually
    public decimal[] runTimeSpit(decimal[] runTime, int startingIndex, decimal[] plotPoints) {
        for(int i = startingIndex; i < (runTime.Length / 4); i++){
            plotPoints[i] = runTime[i]; 
        }
        return plotPoints;
    }

    public void sketchGraph(decimal[] runTime, decimal[] plotPoints, int[] n){
        
        ScottPlot.Plot complexityGraph = new();
        int i = 0;

        while(i <= 12) { 
            decimal[] curLine = runTimeSpit(runTime, i, plotPoints);
            complexityGraph.Add.Scatter(n, curLine);
            i += 4;
        }
        
        complexityGraph.SavePng("graph.png", 400, 300);
    }
}
