using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenstionsHelper
{
    public static class StackExtensions
    {
        public static string PrintStackLine<T>(this Stack<T> stack)
        {
            if (stack == null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder(40);
            while(stack.Count > 1)
            {
                sb.Append(stack.Pop());
                sb.Append(" -> ");
            }
            sb.Append(stack.Pop());
            return sb.ToString();
        }
    }
}
