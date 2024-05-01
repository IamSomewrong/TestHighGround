using TestHighGround;
using FluentAssertions;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPrint()
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15", NumberProcessor.PrepareForPrint(numbers));
            string[] numbers2 = { };
            Assert.AreEqual("", NumberProcessor.PrepareForPrint(numbers2));
        }
        [TestMethod]
        public void TestMethodFirst()
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = NumberProcessor.ProcessNumberFirst(numbers[i]);
            }
            numbers.Length.Should().Be(15);
            Assert.AreEqual("1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz", NumberProcessor.PrepareForPrint(numbers));
        }
        [TestMethod]
        public void TestMethodFirstException()
        {
            string numbers = "a";
            Xunit.Assert.Throws<FormatException>(() =>  NumberProcessor.ProcessNumberFirst(numbers));
        }
        [TestMethod]
        public void TestMethodSecond()
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "60", "105", "420" };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = NumberProcessor.ProcessNumberSecond(numbers[i]);
            }
            Assert.AreEqual("1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz", NumberProcessor.PrepareForPrint(numbers));
        }
        [TestMethod]
        public void TestMethodThird()
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "60", "105", "420" };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = NumberProcessor.ProcessNumberThird(numbers[i]);
            }
            //В условии задания ошибка(12 = dog-muzz, а не fizz-muzz) 
            Assert.AreEqual("1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz", NumberProcessor.PrepareForPrint(numbers));
        }
    }
}