using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check for palindrome:");
            String st = Console.ReadLine();
            Queue q = new Queue();
            Stack stack = new Stack();
            char[] array = st.ToCharArray();

            //Gets all characters to the queue and stack
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
                q.Enqueue(array[i]);

            }

            bool result = true;
            //Compare the characters to determine the input string is palindrome or not
            for (int i = 0; i < array.Length / 2; i++)
            {
                if ((char)stack.Pop() != (char)q.Dequeue())
                {
                    result = false;
                    break;
                }
            }

            if (result == false)
            {
                Console.WriteLine("The input string is not a palindrome");
            }
            else
            {
                Console.WriteLine("The input string is a palindrome");
            }

        }
    }
}
