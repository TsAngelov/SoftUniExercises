using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fields = type.GetFields((BindingFlags)60);

            StringBuilder output = new();
            output.AppendLine($"Class under investigation: {className}");
            foreach (FieldInfo field in fields) 
            {
                if (fieldNames.Contains(field.Name))
                {
                    output.AppendLine($"{field.Name} = {field.GetValue(new Hacker())}");
                }
            }
            return output.ToString().TrimEnd();
        }
    }
}
