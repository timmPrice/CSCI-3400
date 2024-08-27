// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Graphing {

    // diving the values in the array into a smaller array that can be graphed individually
    public decimal[] runTimeSpit(decimal[] runTime, int startingIndex, decimal[] plotPoints) {
        for(int p = startingIndex; p < (runTime.Length / 3); p++){
            plotPoints[p] = runTime[p]; 
        }
        return plotPoints;
    }

    public void sketchGraph(decimal[] runTime, decimal[] plotPoints, int[] n){
        
        ScottPlot.Plot complexityGraph = new();

        for(int i = 0; i < 3; i ++){ 
            decimal[] curLine = runTimeSpit(runTime, i * 4, plotPoints);
            complexityGraph.Add.ScatterLine(n, curLine);
        }
        
        complexityGraph.SavePng("graph.png", 1920, 1080);
    }
}
