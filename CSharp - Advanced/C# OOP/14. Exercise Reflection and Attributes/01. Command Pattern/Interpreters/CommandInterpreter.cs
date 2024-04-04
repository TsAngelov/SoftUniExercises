using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Interpreters
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] parts = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string cmd = $"{parts[0]}Command";
            string[] commandArgs = parts.Skip(1).ToArray();

            Assembly assembly = Assembly.GetEntryAssembly();
            Type type = assembly?.GetTypes().FirstOrDefault(type => type.Name == cmd);

            if (type == null)
            {
                throw new ArgumentException("Invalid command!");
            }

            ICommand command = (ICommand)Activator.CreateInstance(type);

            return command?.Execute(commandArgs);
        }
    }
}
