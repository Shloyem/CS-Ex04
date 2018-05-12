namespace Ex04.Menus.Delegate
{
    public delegate void OnSelectEventHandler();

    public class Executable : MenuItem
    { 
        public event OnSelectEventHandler OnSelect;

        public Executable(string i_Title) : base(i_Title)
        {
        }

        public override bool IsExecutable
        {
            get { return true; }
        }

        public void OnSelected()
        {
            if (OnSelect != null)
            {
                OnSelect.Invoke();
            }
        }

        public override string ToString()
        {
            return OnSelect.ToString();
        }
    }
}