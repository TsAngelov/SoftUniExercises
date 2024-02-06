using System.Text;

namespace DoubleBoxSwap;

public class Box<T> where T : IComparable
{
    private List<T> list;

    public Box()
    {
        list = new List<T>();
    }
    public void Add(T item) 
    {
        list.Add(item);
    }
    public void Swap(int index1, int index2)
    {
        if (index1 < 0 || index1 >= list.Count 
         || index2 < 0 || index1 >= list.Count)
        {
            return;
        }
        var temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
    public int CheckCount(T element) 
    {
        int count = 0;
        foreach (var item in list)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
    public override string ToString() 
    {
        var sb = new StringBuilder();
        foreach (var item in list)
        {
            sb.AppendLine($"{item.GetType()}: {item}");
        }
        return sb.ToString().TrimEnd();
    }
}
