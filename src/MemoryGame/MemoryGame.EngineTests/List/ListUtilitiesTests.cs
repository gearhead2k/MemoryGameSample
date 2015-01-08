using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Engine.List;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MemoryGame.Engine.List.Tests
{
    [TestClass()]
    public class ListUtilitiesTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShuffleTestWithNullList()
        {
            List<int> testList = null;
            testList.Shuffle();
        }

        [TestMethod]
        public void ShuffleTestWithEmptyList()
        {
            var testList = new List<int>();
            testList.Shuffle();
        }

        [TestMethod]
        public void ShuffleTestWithActualList()
        {
            var testList = new List<int>();
            const int cnt = 100;
            int numDifferent = 0;
            const double percentDifferent = .75;

            for (int i = 0; i < cnt; i++)
            {
                testList.Add(i);
            }

            testList.Shuffle();

            for (int i = 0; i < cnt; i++)
            {
                if (i != testList[i])
                {
                    numDifferent += 1;
                }
            }

            Assert.IsTrue(numDifferent >= (int)(percentDifferent * cnt));
        }
    }
}
