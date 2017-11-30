using NUnit.Framework;

namespace Kata1.Test
{
    [TestFixture]
    class KataTests
    {

        Solution _solution;

        [OneTimeSetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void NoDuplicatesReturnsCorrectResults()
        {
            var noDuplicates = new int[] { 1, 2, 5, 7, 9, 100, 2000, 1111, 2222, 0 };

            var result = _solution.FindFirstDuplicate(noDuplicates);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void EmptyListReturnsCorrectResults()
        {
            var noValues = new int[] { };

            var result = _solution.FindFirstDuplicate(noValues);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void NullListReturnsCorrectResults()
        {
            int[] nullList = null;

            var result = _solution.FindFirstDuplicate(nullList);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void DuplicatesReturnsCorrectResults()
        {
            var threeDuplicates = new int[] { 1, 1, 2, 2, 3, 3 };
            var twoDuplicates = new int[] { 1, 2, 1, 2 };

            var resultThreeDuplicates = _solution.FindFirstDuplicate(threeDuplicates);
            var resultTwoDuplicates = _solution.FindFirstDuplicate(twoDuplicates);

            Assert.AreEqual(resultThreeDuplicates, 1);
            Assert.AreEqual(resultTwoDuplicates, 1);
        }
    }
}
