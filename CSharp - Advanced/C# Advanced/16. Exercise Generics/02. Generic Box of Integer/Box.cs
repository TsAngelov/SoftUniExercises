using System.Text;

namespace IntegerBox;

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
