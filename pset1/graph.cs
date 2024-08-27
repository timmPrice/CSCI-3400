// Written by Timothy Price | CSCI 3400 · DSA | Fall 2024 

namespace pset1;

public class Graphing {

    // Dividing the values in the array into a smaller array that can be graphed individually
    public decimal[] runTimeSplit(decimal[] runTime, int startingIndex, int length) {
        decimal[] plotPoints = new decimal[length];
        
    if (length <= 0 || startingIndex < 0 || startingIndex >= runTime.Length) {
        Console.WriteLine("Invalid input: either length is zero or startingIndex is out of bounds.");
        return new decimal[0]; // Return an empty array to avoid graphing errors
    }

        Array.Copy(runTime, startingIndex, plotPoints, 0, length);
        return plotPoints;
    }

    public void sketchGraph(decimal[] runTime, int[] n) {
        
        ScottPlot.Plot complexityGraph = new();

        int pointsPerLine = runTime.Length / 3;
        
        for(int i = 0; i < 3; i++) {
            decimal[] curLine = runTimeSplit(runTime, i * pointsPerLine, pointsPerLine);
            complexityGraph.Add.ScatterLine(n, curLine);
        }
        
        complexityGraph.SavePng("graph.png", 1920, 1080);
    }
    public void sketchLinear(decimal[] runTime, int[] n){

        ScottPlot.Plot linearGraph = new();

        int pointsPerLine = runTime.Length / 3;
        decimal[] curLine = runTimeSplit(runTime, 0, pointsPerLine);
        linearGraph.Add.ScatterLine(n, curLine);


        linearGraph.SavePng("linear.png", 1920, 1080);
    }
}
