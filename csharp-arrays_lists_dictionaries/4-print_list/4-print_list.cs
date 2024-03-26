using System.Collections;

class List {
    public static List<int> CreatePrint(int size){
        if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else{
            List<int> cacheList = new List<int>();
            for(int index = 0; index < size; index++){
            Console.Write(index);
                if(index != size - 1) // Add space if it's not the last number
                    Console.Write(" ");
                cacheList.Add(index);
	    }
            Console.WriteLine();
            return cacheList;
        }
    }
}
