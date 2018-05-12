using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Application
{
    public class CountSpaces : IOnSelectListener
    {
        public void OnSelect()
        {
            DoCountSpaces();
        }

        public void DoCountSpaces()
        {
            string msg;
            int counter = 0;

            Console.WriteLine("Please write a single line sentencec:");
            msg = Console.ReadLine();

            foreach(char c in msg)
            {
                if(c == ' ')
                {
                    counter++;
                }
            }

            Console.WriteLine("The amount of spaces in your sentence is: " + counter);
        }
    }
}
