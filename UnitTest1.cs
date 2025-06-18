namespace TestLeetCode169
{
    public class Tests
    {
        LeetCode169.Solution Solution { get; set; }
        int[] Input { get; set; }
        int ExpectedOutput { get; set; }

        [SetUp]
        public void Setup()
        {
            Solution = new();
        }

        [Test]
        public void Test1()
        {
            Input = [3, 2, 3];
            ExpectedOutput = 3;
            Assert.That(Solution.MajorityElement(Input), Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test2()
        {
            Input = [2, 2, 1, 1, 1, 2, 2];
            ExpectedOutput = 2;
            Assert.That(Solution.MajorityElement(Input), Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test3()
        {
            Input = [7];
            ExpectedOutput = 7;
            Assert.That(Solution.MajorityElement(Input), Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test4()
        {
            Input = [1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5];
            ExpectedOutput = 5;
            Assert.That(Solution.MajorityElement(Input), Is.EqualTo(ExpectedOutput));
        }
    }
}
