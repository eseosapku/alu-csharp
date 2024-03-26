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
                Console.WriteLine(index + " ");
                cacheList.Add(index);
            }
            Console.WriteLine();
            return cacheList;
        }
    }
}
