using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Application
{
    internal class CharsCount : IOnSelectListener
    {
        public void OnSelect()
        {
            DoCharsCount();
        }

        public void DoCharsCount()
        {
            string msg;
            int counter = 0;

            Console.WriteLine("Please write a single line sentencec:");
            msg = Console.ReadLine();

            foreach(char c in msg)
            {
                if(!char.IsWhiteSpace(c))
                {
                    counter++;
                }
            }

            Console.WriteLine("The amount of chars in your sentence is: " + counter);
        }
    }
}
