using System;
using NUnit.Framework;


namespace Kata.Tests
{
    public class StringCalculatorTests
    {
        

        [Test]
        public void Add_SumAnEmptyString_ReturnZero()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("");
            //Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Add_SumAnEmptyString_Returnone()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("1");
            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Add_SumNumberOneAndTwo_ReturnThree()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("1,2");
            //Assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Add_SumNumberOneAndTwoAndFive_ReturnThreeEight()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("1,2,5");
            //Assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Add_SumNumberOneAndTwoAndFiveUsingNewLineAsSeperator_ReturnThree()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("1\n2,5");
            //Assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Add_SumNumberOneAndTwoAndFiveUsingDifferentDelimiters_ReturnThree()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();



            // Act
            int result = sc.Add("//;\n1;2;5");
            //Assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Add_SumNumberOneAndNegativetwoAndNegativeFive_ThrowAnExceptionAndSendMessageNegativesAreNotAllowedShowingTheNegativeNumbers()
        {
            //Arrange
            StringCalculator sc = new StringCalculator();

            try
            {


                int result = sc.Add("1,-2,-5");
                //Assert
                Assert.Fail("Expected to fail but instead returned" + result);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Negatives are not allowed -2,-5", ex.Message);
            }
        }
    }

    
}

namespace Kata.Tests
{
    class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal int Add(string v)
        {
            throw new NotImplementedException();
        }
    }
}