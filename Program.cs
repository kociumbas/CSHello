using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Write your name here: ");
            string name = Console.ReadLine();
            if (name.Length == 0)
            {
                Console.Error.WriteLine("\n\n\t*** Error: no name was given!\n\n");
                return;
            }
            bool woman = (name.ToLower()[name.Length - 1] == 'a');
            if (name == "Kuba" || name == "Barnaba") woman = false;
//Console.WriteLine("Let me guess, you are " + (woman ? "a woman" : "a boy") + "!");
            Console.WriteLine("Let me guess, you are {0}!", (woman ? "a woman" : "a boy"));
//Show a message box with text (requires adding reference to Windows.Forms in solution explorer)
            System.Windows.Forms.MessageBox.Show("Hello World!");
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
