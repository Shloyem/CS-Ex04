using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu m_MenuTreeHead;

        public MainMenu(string i_Title)
        {
            m_MenuTreeHead = new SubMenu(i_Title, null);
        }

        public SubMenu Menu
        {
            get { return m_MenuTreeHead; }
        }

        public void ShowMenu()
        {
            ShowMenuFromSpecificPosition(m_MenuTreeHead);
        }

        public void ShowMenuFromSpecificPosition(SubMenu i_SubMenu)
        {
            MenuItem currentMenuItem = i_SubMenu;
            SubMenu currentSubMenu = i_SubMenu;
            int userInput;

            do
            {
                if(currentMenuItem.IsExecutable)
                {
                    Console.Clear();
                    ((Executable)currentMenuItem).OnSelected();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadKey();
                    ////currentSubMenu = m_MenuTreeHead;      // Comment this line to stop the menu from restarting after each execution
                }
                else
                {
                    currentSubMenu = currentMenuItem as SubMenu;
                }

                Console.Clear();
                Console.WriteLine(currentSubMenu.ToString());
                userInput = getIntFromUserWithRange(0, currentSubMenu.GetAvailableOptions().Length - 1);
                currentMenuItem = currentSubMenu.GetMenuItem(userInput);
            }
            while (currentMenuItem != null);
        }

        private int getIntFromUserWithRange(int i_Min, int i_Max)
        {
            bool isParseable = false;
            bool isValid = false;
            bool isInRange = false;
            string userInput;
            int parsedInt;

            do
            {
                userInput = Console.ReadLine();
                isParseable = int.TryParse(userInput, out parsedInt);
                isInRange = parsedInt >= i_Min && parsedInt <= i_Max;
                isValid = isInRange && isParseable;

                if (!isValid)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            while (!isValid);

            return parsedInt;
        }
    }
}
