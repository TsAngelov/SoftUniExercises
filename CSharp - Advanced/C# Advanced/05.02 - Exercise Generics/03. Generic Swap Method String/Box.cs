using System.Text;

namespace StringBoxSwap;

public class Box<T>
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
