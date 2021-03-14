using System;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace UnitTestProject.LogAnChar5.EventHandler
{
    [TestFixture]
    public class PresenterTests
    {
        [Test]
        public void ctor_WhenViewIsLoaded_CallsViewRender()
        {
            var mockView = Substitute.For<IView>();
            var presenter = new Presenter(mockView);

            mockView.Loaded += Raise.Event<Action>();

            mockView.Received()
                .Render(Arg.Is<string>(s => s.Contains("Hello World")));
        }

        [Test]
        public void ctor_WhenViewHasError_CallsLogger()
        {
            var stubView = Substitute.For<IView>();
            var mockLogger = Substitute.For<ILogger>();
            var presenter = new Presenter(stubView, mockLogger);
            // ---
            // var stubView = new Mock<IView>();
            // var mockLogger = new Mock<ILogger>();
            // var presenter = new Presenter(stubView.Object, mockLogger.Object);

            stubView.ErrorOccured += Raise.Event<Action<string>>("fake error");
            // ---
            // stubView.Raise(view => view.ErrorOccured += null, "fake error");

            mockLogger.Received()
                .LogError(Arg.Is<string>(s => s.Contains("fake error")));
            // ---
            // mockLogger.Verify(
            //     logger => logger.LogError(It.Is<string>(
            //         s => s.Contains("fake error"))));
        }
    }
}