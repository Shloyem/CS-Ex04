namespace Ex04.Menus.Delegate
{
    public abstract class MenuItem
    {
        private readonly string m_Title;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public string Title
        {
            get { return m_Title; }
        }

        public abstract bool IsExecutable
        {
            get;
        }
    }
}
