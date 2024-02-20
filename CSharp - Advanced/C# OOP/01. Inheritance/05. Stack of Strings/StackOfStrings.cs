﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool isEmpty() => Count == 0;
        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
            {
                Push(element);
            }
        }
    }
}
