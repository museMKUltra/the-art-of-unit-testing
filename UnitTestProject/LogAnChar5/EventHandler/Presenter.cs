using System;

namespace UnitTestProject.LogAnChar5.EventHandler
{
    public class Presenter
    {
        public readonly IView _view;
        public readonly ILogger _logger;

        public Presenter(IView view)
        {
            _view = view;
            _view.Loaded += OnLoaded;
        }

        public Presenter(IView view, ILogger logger)
        {
            _view = view;
            _logger = logger;
            _view.ErrorOccured += error => _logger.LogError(error);
        }

        private void OnLoaded()
        {
            _view.Render("Hello World");
        }
    }

    public interface IView
    {
        event Action Loaded;
        event Action<string> ErrorOccured;
        void Render(string text);
        void DoSomething();
    }

    public interface ILogger
    {
        void LogError(string error);
    }
}