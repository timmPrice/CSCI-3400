namespace ConsoleApplication1;

public class program {
    
    public static void Main(){
        
        Queue<int> theQueue = new Queue<int>{};
        for (int i = 0; i < 100; i++){
            theQueue.Enqueue(i);
        }
        int value = 3;
        bool contains = theQueue.Contains(value);
        Console.WriteLine("the queue contains " + value + " : " + contains);
    }
}
