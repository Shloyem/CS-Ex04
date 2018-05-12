using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public delegate void MethodExecutionDelegate();

    public class Executable : MenuItem
    { 
        private readonly List<IOnSelectListener> m_Listiners;

        public Executable(string i_Title) : base(i_Title)
        {
            m_Listiners = new List<IOnSelectListener>();
        }

        public void AddOnSelectListener(IOnSelectListener i_Listener)
        {
            m_Listiners.Add(i_Listener);
        }

        public void RemoveOnSelectListener(IOnSelectListener i_Listener)
        {
            m_Listiners.Remove(i_Listener);
        }

        public override bool IsExecutable
        {
            get { return true; }
        }

        public void OnSelected()
        {
            if (m_Listiners != null)
            {
                foreach(IOnSelectListener listener in m_Listiners)
                {
                    listener.OnSelect();
                }
            }
        }

        public override string ToString()
        {
            return m_Listiners.ToString();
        }
    }
}