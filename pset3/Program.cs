namespace MyPrograms;

public class Program{
    
    public static void Main(){
        OurList<int> list = new OurList<int>();
        OurList<int> newList = new OurList<int>();
        
        bool check = list.IsEmpty();
        Console.WriteLine("The list is empty: " + check); 
        for(int i = 0; i < 100; i++){
            list.Add(i);
        } 
        String theList = list.ToString();
        Console.WriteLine("Original List");
        Console.WriteLine(theList);
        
        newList = list.skipList(5);
        String theNewList = newList.ToString(); 
        Console.WriteLine("New List");
        Console.WriteLine(theNewList);
    }
    
}
