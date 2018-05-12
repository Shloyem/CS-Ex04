using System.Collections.Generic;
using System.Text;
using System;

namespace Ex04.Menus.Delegate
{
    public class SubMenu : MenuItem
    {
        private readonly List<string> m_ListOfSubMenuTitles;
        private readonly Dictionary<string, MenuItem> m_TitlesToMenuOptionMapping;

        public SubMenu(string i_Title,  SubMenu i_ParentMenuOption) : base(i_Title)
        {
            string fisrtOptionTitle = i_ParentMenuOption == null ? "Exit" : "Back";

            m_ListOfSubMenuTitles = new List<string>();
            m_TitlesToMenuOptionMapping = new Dictionary<string, MenuItem>();
            m_ListOfSubMenuTitles.Add(fisrtOptionTitle);
            m_TitlesToMenuOptionMapping.Add(fisrtOptionTitle, i_ParentMenuOption);
        }

        // A short way to call GetSubMenu for easy travelling along the menu.
        public SubMenu this[string i_Title]
        {
            get { return GetSubMenu(i_Title); }
        }

        // A short way to call GetSubMenu for easy travelling along the menu.
        public SubMenu this[int i_Index]
        {
            get { return GetSubMenu(i_Index); }
        }

        public int AddSubMenuItem(string i_Title)
        {
            int itemIndex = m_ListOfSubMenuTitles.Count;
            string updatedTitle = string.Format(@"{0}\{1}", this.Title, i_Title);

            m_TitlesToMenuOptionMapping.Add(i_Title, new SubMenu(updatedTitle, this));
            m_ListOfSubMenuTitles.Add(i_Title);

            return itemIndex;
        }

        public int AddExecutableItem(string i_Title)
        {
            int itemIndex = m_ListOfSubMenuTitles.Count;
            string updatedTitle = string.Format(@"{0}\{1}", this.Title, i_Title);

            m_TitlesToMenuOptionMapping.Add(i_Title, new Executable(updatedTitle));
            m_ListOfSubMenuTitles.Add(i_Title);

            return itemIndex;
        }

        public SubMenu GetSubMenu(string i_Title)
        {
            SubMenu nextSubMenu = m_TitlesToMenuOptionMapping[i_Title] as SubMenu;

            if (nextSubMenu != null)
            {
                return nextSubMenu;
            }
            else
            {
                throw new ArgumentException("Given title does not represent a sub menu.");
            }
        }

        public SubMenu GetSubMenu(int i_Index)
        {
            SubMenu nextSubMenu = m_TitlesToMenuOptionMapping[m_ListOfSubMenuTitles[i_Index]] as SubMenu;

            if (nextSubMenu != null)
            {
                return nextSubMenu;
            }
            else
            {
                throw new ArgumentException("Given index does not represent a sub menu.");
            }
        }

        public Executable GetExecutableItem(string i_Title)
        {
            Executable executableItem = m_TitlesToMenuOptionMapping[i_Title] as Executable;

            if (executableItem != null)
            {
                return executableItem;
            }
            else
            {
                throw new ArgumentException("Given title does not represent an executable item.");
            }
        }

        public Executable GetExecutableItem(int i_Index)
        {
            Executable executableItem = m_TitlesToMenuOptionMapping[m_ListOfSubMenuTitles[i_Index]] as Executable;

            if (executableItem != null)
            {
                return executableItem;
            }
            else
            {
                throw new ArgumentException("Given index does not represent an executable item.");
            }
        }

        internal MenuItem GetMenuItem(int i_Index)
        {
            return m_TitlesToMenuOptionMapping[m_ListOfSubMenuTitles[i_Index]];
        }

        public string[] GetAvailableOptions()
        {
            return m_ListOfSubMenuTitles.ToArray();
        }

        public void RemoveMenuItem(string i_Title)
        {
            m_TitlesToMenuOptionMapping.Remove(i_Title);
            m_ListOfSubMenuTitles.Remove(i_Title);
        }

        public int OptionsCount()
        {
            return m_ListOfSubMenuTitles.Count;
        }

        public override bool IsExecutable
        {
            get { return false; }
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendLine(this.Title);
            msg.AppendLine();
            msg.AppendLine("Please select an option:");

            for (int i = 1; i < m_ListOfSubMenuTitles.Count; i++)
            {
                msg.AppendLine(string.Format("\t{0}. {1}", i, m_ListOfSubMenuTitles[i]));
            }

            msg.AppendLine(string.Format("\t0. {0}", m_ListOfSubMenuTitles[0]));

            return msg.ToString();
        }
    }
}
