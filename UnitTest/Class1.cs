using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest
    {

        [Test]
        public void UnitTestPixelPerInch_Input10and10and5_OutputValidUnitTestPixelPerInche()
        {
            //Arange
            int screenWidth = 10;
            int screenHeight = 10;
            int diagonalSize = 5;

            string expected = "PixelPerInch";

            //Act
            string result = PixelCalc.Report(screenWidth, screenHeight, diagonalSize);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void UnitTestPixelPerInch_Input15and10and5_OutputValidUnitTestPixelPerInche()
        {
            //Arange
            int screenWidth = 15;
            int screenHeight = 10;
            int diagonalSize = 5;

            string expected = "PixelPerInch";

            //Act
            string result = PixelCalc.Report(screenWidth, screenHeight, diagonalSize);

            //Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void UnitTestPixelPerInch_Input20and10and5_OutputValidUnitTestPixelPerInche()
        {
            //Arange
            int screenWidth = 20;
            int screenHeight = 10;
            int diagonalSize = 5;

            string expected = "PixelPerInch";

            //Act
            string result = PixelCalc.Report(screenWidth, screenHeight, diagonalSize);

            //Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void UnitTestPixelPerInch_Input10and20and5_OutputValidUnitTestPixelPerInche()
        {
            //Arange
            int screenWidth = 10;
            int screenHeight = 20;
            int diagonalSize = 5;

            string expected = "PixelPerInch";

            //Act
            string result = PixelCalc.Report(screenWidth, screenHeight, diagonalSize);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void UnitTestPixelPerInch_Input10and10and8_OutputValidUnitTestPixelPerInche()
        {
            //Arange
            int screenWidth = 10;
            int screenHeight = 10;
            int diagonalSize = ;

            string expected = "PixelPerInch";

            //Act
            string result = PixelCalc.Report(screenWidth, screenHeight, diagonalSize);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
