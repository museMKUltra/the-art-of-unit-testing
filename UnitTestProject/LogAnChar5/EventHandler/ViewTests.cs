using NUnit.Framework;

namespace UnitTestProject.LogAnChar5.EventHandler
{
    [TestFixture]
    public class ViewTests
    {
        [Test]
        public void DoSomething_EventFiringManual_ChangeLoadFired()
        {
            var loadFired = false;
            var view = new View();

            view.Loaded += () => { loadFired = true; };
            view.DoSomething();

            Assert.That(loadFired, Is.EqualTo(true));
        }
    }
}