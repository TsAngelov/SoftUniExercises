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
        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType($"Stealer.{className}");
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMerthods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder mistakes = new();
            foreach (FieldInfo field in fields)
            {
                mistakes.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                mistakes.AppendLine($"{publicMethod.Name} have to be public!");
            }
            foreach (MethodInfo publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                mistakes.AppendLine($"{publicMethod.Name} have to be private!");
            }
            return mistakes.ToString().TrimEnd();
        }
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
