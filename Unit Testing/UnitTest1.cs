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
        public void TestValidationNotEmpty()
        {
            Assert.True(Utils.Validate("anything"));
        }
        [Test]
        public void TestValidationEmpty()
        {
            Assert.False(Utils.Validate(""));
        }
        [Test]
        public void TestLoginRealAccount()
        {
            Assert.That(Utils.login("harry","harry"), Is.EqualTo(15));
        }
    }
}