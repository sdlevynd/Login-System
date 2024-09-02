using Login_System;

namespace Unit_Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.True(Utils.Validate());
        }
        [Test]
        public void Test2()
        {
            Assert.That(Utils.login, Is.EqualTo(0));
        }
    }
}