using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Application
{
    public class DisplayVersion : IOnSelectListener
    {
        public void OnSelect()
        {
            DoDisplayVersion();
        }

        public void DoDisplayVersion()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }
    }
}
