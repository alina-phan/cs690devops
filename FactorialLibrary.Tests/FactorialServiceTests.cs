namespace FactorialLibrary.Tests  // ✅ Fixed namespace declaration (removed `;`)
{
    using System;
    using Xunit;
    using FactorialLibrary;  // ✅ Ensuring FactorialService is accessible

    public class FactorialServiceTests
    {
        [Fact]
        public void Test1()
        {
            var result = FactorialService.Factorial(0);
            Assert.Equal(1, result);  // ✅ Factorial of 0 should be 1
        }

        [Fact]
        public void Test_negative()
        {
            Assert.Throws<InvalidOperationException>(() => {
                var result = FactorialService.Factorial(-1);
            });  // ✅ Should throw an exception for negative numbers
        }
    }
}
