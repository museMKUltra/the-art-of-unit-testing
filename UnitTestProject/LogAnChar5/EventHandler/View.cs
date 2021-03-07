using System;

namespace UnitTestProject.LogAnChar5.EventHandler
{
    public class View : IView
    {
        public event Action Loaded;
        public event Action<string> ErrorOccured;
        public void Render(string text)
        {
            throw new NotImplementedException();
        }

        public void DoSomething()
        {
            Loaded?.Invoke();
        }
    }
}