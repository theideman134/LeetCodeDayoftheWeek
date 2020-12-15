using LeetCodeDayofthe_Week;
using NUnit.Framework;

namespace LeetCodeDayoftheWeekTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NullTest()
        {
            Assert.Pass();
        }
        [Test]
        public void EmptyTest()
        {
            Assert.Pass();
        }

        /*
        Input: day = 31, month = 8, year = 2019
        Output: "Saturday"
        */

        [Test]
        public void Test1()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(31, 8, 2019);
            Assert.AreEqual("Saturday", result);

        }

        /*
         Input: day = 18, month = 7, year = 1999
         Output: "Sunday"
        */

        [Test]
        public void Test2()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(18,7,1999);
            Assert.AreEqual("Sunday", result);
        }

        /*
        Input: day = 15, month = 8, year = 1993
        Output: "Sunday"
        */

        [Test]
        public void Test3()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(15, 8, 1993);
            Assert.AreEqual("Sunday", result);
        }

        /*
        Input: day = 20, month = 7, year = 1969
        Output: "Sunday"
        */

        [Test]
        public void Test4()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(15, 8, 1993);
            Assert.AreEqual("Sunday", result);
        }

        /*
        Input: day = 1, month = 1, year = 2000
        Output: "Saturday"
        */

        //1 January 2000 was a Saturday.

        [Test]
        public void Test5()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(1, 1, 2000);
            Assert.AreEqual("Saturday", result);
        }

        /*
        Input: day = 14, month = 10, year = 1066
        Output: "Saturday"
        */

        [Test]
        public void Test6()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(14, 10,1066);
            Assert.AreEqual("Saturday", result);
        }

        /*
        Input: day = 2, month = 2, year = 2020
        Output: "Sunday"
        */

        [Test]
        public void Test7()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(2, 2, 2020);
            Assert.AreEqual("Sunday", result);
        }

        /*
        Input: day = 15, month = 6, year = 2000
        Output: "Thursday"
        */

        [Test]
        public void Test8()
        {
            var solution = new Solution();
            string result = solution.DayOfTheWeek(15, 6, 2000);
            Assert.AreEqual("Thursday", result);
        }
    }
}