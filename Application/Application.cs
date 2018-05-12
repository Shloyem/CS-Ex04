using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegate;
using Ex04.Menus.Interfaces;

namespace Application
{
    public class Application
    {
        public void StartDemonstration()
        {
            CreateDelegateMenu();
            CreateInterfacesMenu();
        }

        public void CreateDelegateMenu()
        {
            Ex04.Menus.Delegate.MainMenu delegateMenu = new Ex04.Menus.Delegate.MainMenu("Delegate menu");
            DisplayVersion displayVersion = new DisplayVersion();
            CountSpaces countSpaces = new CountSpaces();
            CharsCount charsCount = new CharsCount();
            ShowTime showTime = new ShowTime();
            ShowDate showDate = new ShowDate();

            delegateMenu.Menu.AddSubMenuItem("Actions and info");
            delegateMenu.Menu["Actions and info"].AddExecutableItem("Display Version");
            delegateMenu.Menu["Actions and info"].GetExecutableItem("Display Version").OnSelect += displayVersion.DoDisplayVersion;
            delegateMenu.Menu["Actions and info"].AddSubMenuItem("Actions");
            delegateMenu.Menu["Actions and info"]["Actions"].AddExecutableItem("Count Spaces");
            delegateMenu.Menu["Actions and info"]["Actions"].GetExecutableItem("Count Spaces").OnSelect += countSpaces.DoCountSpaces;
            delegateMenu.Menu["Actions and info"]["Actions"].AddExecutableItem("Chars Count");
            delegateMenu.Menu["Actions and info"]["Actions"].GetExecutableItem("Chars Count").OnSelect += charsCount.DoCharsCount;
            delegateMenu.Menu.AddSubMenuItem("Show Date/Time");
            delegateMenu.Menu["Show Date/Time"].AddExecutableItem("Show Time");
            delegateMenu.Menu["Show Date/Time"].GetExecutableItem("Show Time").OnSelect += showTime.DoShowTime;
            delegateMenu.Menu["Show Date/Time"].AddExecutableItem("Show Date");
            delegateMenu.Menu["Show Date/Time"].GetExecutableItem("Show Date").OnSelect += showDate.DoShowDate;

            delegateMenu.ShowMenu();
        }

        public void CreateInterfacesMenu()
        {
            Ex04.Menus.Interfaces.MainMenu interfacesMenu = new Ex04.Menus.Interfaces.MainMenu("Interface menu");
            DisplayVersion displayVersion = new DisplayVersion();
            CountSpaces countSpaces = new CountSpaces();
            CharsCount charsCount = new CharsCount();
            ShowTime showTime = new ShowTime();
            ShowDate showDate = new ShowDate();

            interfacesMenu.Menu.AddSubMenuItem("Actions and info");
            interfacesMenu.Menu["Actions and info"].AddExecutableItem("Display Version");
            interfacesMenu.Menu["Actions and info"].GetExecutableItem("Display Version").AddOnSelectListener(displayVersion);
            interfacesMenu.Menu["Actions and info"].AddSubMenuItem("Actions");
            interfacesMenu.Menu["Actions and info"]["Actions"].AddExecutableItem("Count Spaces");
            interfacesMenu.Menu["Actions and info"]["Actions"].GetExecutableItem("Count Spaces").AddOnSelectListener(countSpaces);
            interfacesMenu.Menu["Actions and info"]["Actions"].AddExecutableItem("Chars Count");
            interfacesMenu.Menu["Actions and info"]["Actions"].GetExecutableItem("Chars Count").AddOnSelectListener(charsCount);
            interfacesMenu.Menu.AddSubMenuItem("Show Date/Time");
            interfacesMenu.Menu["Show Date/Time"].AddExecutableItem("Show Time");
            interfacesMenu.Menu["Show Date/Time"].GetExecutableItem("Show Time").AddOnSelectListener(showTime);
            interfacesMenu.Menu["Show Date/Time"].AddExecutableItem("Show Date");
            interfacesMenu.Menu["Show Date/Time"].GetExecutableItem("Show Date").AddOnSelectListener(showDate);

            interfacesMenu.ShowMenu();
        }
    }
}
