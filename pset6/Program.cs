namespace ConsoleApplication1;

public class Program{
	public static void Main(){
		BinSearchTree<int> bstree = new BinSearchTree<int>{};
		
        for(int i = 0; i < 100; i++){
			bstree.Insert(i);
		}
        
        int depth = bstree.FindDepth();
        Console.WriteLine("this is the depth " + depth);
	}
}
