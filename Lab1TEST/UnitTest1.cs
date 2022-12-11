using Lab1;
namespace Lab1TEST
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void CreateInstance()
        {
            Generator generator = new Generator(20);
            Assert.IsNotNull(generator);

        }

        [TestMethod]
        public void GetResult() 
        {
            Generator generator = new Generator(20);
            generator.UserUpdate(20);
            string reuslt = generator.ReturnResult();
            Assert.IsNotNull(reuslt);
        }

        [TestMethod]
        public void UserInputEqual()
        {
            Generator generator = new Generator(20);
            generator.UserUpdate(20);
            string reuslt = generator.ReturnResult();
            string expected = "Числа равны!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void UserInputDufferenceMuchMore()
        {
            Generator generator = new Generator(20);
            generator.UserUpdate(200);
            string reuslt = generator.ReturnResult();
            string expected = "Много больше!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void UserInputDufferenceMore()
        {
            Generator generator = new Generator(20);
            generator.UserUpdate(100);
            string reuslt = generator.ReturnResult();
            string expected = "Больше!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void UserInputDufferenceFewMore()
        {
            Generator generator = new Generator(20);
            generator.UserUpdate(25);
            string reuslt = generator.ReturnResult();
            string expected = "Немного больше!";
            Assert.AreEqual(expected, reuslt);
        }

        
        [TestMethod]
        public void UserInputDufferenceMuchLess()
        {
            Generator generator = new Generator(50);
            generator.UserUpdate(1);
            string reuslt = generator.ReturnResult();
            string expected = "Много меньше!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void UserInputDufferenceLess()
        {
            Generator generator = new Generator(50);
            generator.UserUpdate(23);
            string reuslt = generator.ReturnResult();
            string expected = "Меньше!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void UserInputDufferenceFewLess()
        {
            Generator generator = new Generator(50);
            generator.UserUpdate(46);
            string reuslt = generator.ReturnResult();
            string expected = "Немного меньше!";
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void ReturnNotEquallStatus()
        {
            Generator generator = new Generator(60);
            generator.UserUpdate(46);
            bool reuslt = generator.GetSuccess();
            bool expected = false;
            Assert.AreEqual(expected, reuslt);
        }

        [TestMethod]
        public void ReturnEquallStatus()
        {
            Generator generator = new Generator(70);
            generator.UserUpdate(70);
            bool reuslt = generator.GetSuccess();
            bool expected = true;
            Assert.AreEqual(expected, reuslt);
        }
    }
}