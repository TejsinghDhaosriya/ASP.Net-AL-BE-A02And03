using CalculatorWebApplication.Service.Impl;

namespace UnitTests.Service
{
    public class MathServiceTest
    {

         [Fact]
        public void ShouldAddTwoNumber()
        {
            double number = 2;
            double number2 = 4;

            var math =new MathService();
            var res = math.Add(number, number2);

            Assert.Equal(6, res);
        }

        [Fact]
        public void ShouldSubtractTwoNumber()
        {
            double number = 2;
            double number2 = 4;

            var math = new MathService();
            var res = math.Subtract(number, number2);
            Assert.Equal(-2, res);
        }

        [Fact]
        public void ShouldMultiplyTwoNumber()
        {
            double number = 2;
            double number2 = 4;

            var math = new MathService();
            var res = math.Multiply(number, number2);

            Assert.Equal(8, res);
        }

        [Fact]
        public void ShouldMultiplyThreeNumber()
        {
            double number = 2;
            double number2 = 4;
            double number3 = 3;

            var math = new MathService();
            var res = math.Multiply(number, number2,number3);

            Assert.Equal(24, res);
        }

        [Fact]
        public void ShouldDivideTwoNumber()
        {
            double number = 24;
            double number2 = 3;

            var math = new MathService();
            var res = math.Divide(number, number2);

            Assert.Equal(8, res);
        }
    }
}
