using System;
using System.Collections;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int listSize = myList.Count;
        List<int> cacheList = new List<int>();

        if (index >= 0 && index < listSize)
        {
            for (int i = 0; i < listSize; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    cacheList.Add(myList[i]);
                }
            }

            return cacheList;
        }
        else
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
    }
}
