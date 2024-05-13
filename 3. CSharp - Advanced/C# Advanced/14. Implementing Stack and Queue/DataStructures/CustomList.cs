using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures;

public class CustomList
{
    private const int InitialCapacity = 2;
    private int[] items;
    public CustomList()
    {
        items = new int[InitialCapacity];
    }
    
    public int Count { get; private set; }
    public int this[int index]
    {
        get
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return items[index];
        }
        set
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            items[index] = value;
        }
    }
    
    public void Add(int item)
    {
        if (Count == items.Length)
        {
            Resize();
        }
        items[Count] = item;
        Count++;
    }
    public int RemoveAt(int index)
    {
        if (index >= Count)
        {
            throw new ArgumentOutOfRangeException();
        }
        var item = items[index];
        items[index] = default(int);
        Shift(index);

        Count--;
        if (Count <= items.Length/4)
        {
            Shrink();
        }

        return item;
    }
    public void Insert(int index, int element)
    {
        if (index > Count)
        {
            throw new IndexOutOfRangeException();
        }
        if (Count >= items.Length)
        {
            Resize();
        }
        ShiftToRight(index);
        items[index] = element;
        Count++;
    }
    public bool Contains(int element)
    {
        bool contains = false;
        for (int i = 0; i < Count; i++)
        {
            if (items[i] == element)
            {
                contains = true;
            }
        }
        return contains;
    }
    public void Swap(int firstIndex, int secondIndex)
    {
        if (firstIndex >= Count || secondIndex >= Count ||
            firstIndex < 0 || secondIndex < 0)
        {
            throw new IndexOutOfRangeException();
        }
        var temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }
    private void Resize()
    {
        int[] copy = new int[items.Length * 2];
        for (int i = 0; i < items.Length; i++)
        {
            copy[i] = items[i];
        }
        items = copy;
    }
    private void Shift(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
    }
    private void Shrink()
    {
        int[] copy = new int[items.Length / 2];
        for (int i = 0; i < Count; i++)
        {
            copy[i] = items[i];
        }
        items = copy;
    }
    private void ShiftToRight(int index)
    {
        for (int i = Count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
    }
}
