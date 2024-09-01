public class linkedList{

    private class Node {
    
        private int value;
        public Node next;
           
        public Node(int value) {
            this.value = value;
        }        

    }

    private Node last; 
    private Node first; 
    
    public void addLast(int item){
        Node node = new Node(item);

        if (first == null){
            first = last = node;
        } else {
            last.next = node;
            last = node;
        }
    }

    public void addFirst(int item){
        Node node = new Node(item);

        if (first == null){
            first = last = node;
        } else {
            first.next = node;
            first = node;
        }
    }

    public void removeLast(){
        if(first == null){
            throw new ArgumentNullException();
        } else if(last == first){
            first = last = null;
        } else {
            // keep trying until we find last?
            Node current = first;
            while(current != null){
                if (current.next == last){
                    break;
                }
                current = current.next;
            }

            last = current;
            last.next = null;
        }


    }
}


