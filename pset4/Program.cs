namespace ConsoleApplication1;

public class Program{
    
    public static void Main(){
        OurStack<int> stack = new OurStack<int>();
        for(int i = 0; i < 100; i++){
            stack.Push(i);
        }
        string theStack = stack.ToString();
        Console.WriteLine(theStack);
        int value = 55;
        int distance = stack.distanceFromTop(value);
        Console.WriteLine(value + " is " + distance + "places from the top");
    }
}
