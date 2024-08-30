namespace MyPrograms;

public class Program{
    
    public static void Main(){
        OurList<int> list = new OurList<int>();
        
        bool check = list.IsEmpty();
        Console.WriteLine("The list is empty: " + check); 
        for(int i = 0; i < 100; i++){
            list.Add(i);
        } 
        String theList = list.ToString();
        Console.WriteLine(theList); 
    }
    
}
