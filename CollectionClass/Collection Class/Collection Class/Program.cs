using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Collection : CollectionBase<T>
{
    public void Add(Object item)
    {
        InnerList.Add(item);
    }

    public void Remove(Object item)
    {
        InnerList.Remove(item);
    }

    public new void Clear()
    {
        InnerList.Clear();
    }

    public new int Count()
    {
        return InnerList.Count;
    }
}





namespace Collection_Class
{
    class chapter1
    {
        static void Main(string[] args)
        {
            Collection names = new Collection();
            names.Add("M");
            names.Add("R");
            names.Add("K");
            names.Add("Lover");
            foreach (Object name in names)
                Console.WriteLine(name);
            Console.WriteLine("Number of names: " + names.Count());
            names.Remove("Loves");
            Console.WriteLine("Number of names: " + names.Count());
            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());
        
        }
    }
}
