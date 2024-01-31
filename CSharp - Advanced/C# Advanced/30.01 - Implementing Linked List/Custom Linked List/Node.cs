using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Linked_List;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }
    public Node(int value) 
    {
        Value = value;
    }
    public override string ToString()
    {
        return $"{Previous?.Value} <- {Value} -> {Next?.Value}";
    }
}
