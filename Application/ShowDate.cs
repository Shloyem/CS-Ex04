using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Application
{
    public class ShowDate : IOnSelectListener
    {
        public void OnSelect()
        {
            DoShowDate();
        }

        public void DoShowDate()
        {
            Console.WriteLine(DateTime.Now.Date.ToShortDateString());
        }
    }
}
