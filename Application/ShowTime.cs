using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Application
{
    public class ShowTime : IOnSelectListener
    {
        public void OnSelect()
        {
            DoShowTime();
        }

        public void DoShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
