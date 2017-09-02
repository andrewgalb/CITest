using System;
using Xunit;
using HopeToGod;

namespace HopeToGodTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Multiply()
        {
            var expected = 6;
            var actual = Program.Multiply(3,2);
            Assert.Equal(expected, actual);

        }

		[Fact]
		public void Test_Multiply2()
		{
			var expected = 6;
			var actual = Program.Multiply(7, 2);
			Assert.Equal(expected, actual);

		}
    }
}
