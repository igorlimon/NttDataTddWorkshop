using System;
using AutoFixture;
using Shouldly;
using Xunit;

namespace TddWorkShop.StringCalculator.UnitTests
{
    public class StringCalculatorAppUnitTests
    {
        [Fact]
        public void Add_PassEmptyString_ReturnZero()
        {
            // arrange
            var sut = new StringCalculatorApp();

            // act
            var result = sut.Add(string.Empty);

            // assert
            result.ShouldBe(0);
        }

        [Fact]
        public void Add_PassOneNumber_ReturnSameNumber()
        {
            // arrange
            var fixture = new Fixture();
            int input = fixture.Create<int>();
            string inputAsString = input.ToString();
            var sut = new StringCalculatorApp();

            // act
            var result = sut.Add(inputAsString);

            // assert
            result.ShouldBe(input);
        }

        [Fact]
        public void Add_PassTwoNumbers_ReturnSumOfThem()
        {
            // arrange
            var fixture = new Fixture();
            int number1 = fixture.Create<int>();
            int number2 = fixture.Create<int>();
            string input = $"{number1},{number2}";
            var sut = new StringCalculatorApp();

            // act
            var result = sut.Add(input);

            // assert
            result.ShouldBe(number1 + number2);
        }
    }
}
