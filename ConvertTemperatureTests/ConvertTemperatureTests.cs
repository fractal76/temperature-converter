using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TemperatureConverter.Tests
{
    [TestClass()]
    public class ConvertTemperatureTests
    {
        [TestMethod()]
        public void CelsiusToFarenheitTest()
        {
            float celsius = 1f;
            float expected = 33.8f;
            float actual = ConvertTemperature.CelsiusToFarenheit(celsius);
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void FarenheitToCelsiusTest()
        {
            float farenheit = 1f;
            float expected = -17.22f;
            float actual = float.Parse(ConvertTemperature.FarenheitToCelsius(farenheit).ToString("#.##"));
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CelsiusToKelvinTest()
        {
            float celsius = 1f;
            float expected = 274.15f;
            float actual = ConvertTemperature.CelsiusToKelvin(celsius);
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void KelvinToCelsiusTest()
        {
            float kelvin = 1f;
            float expected = -272.15f;
            float actual = ConvertTemperature.KelvinToCelsius(kelvin);
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void FarenheitToKelvinTest()
        {
            float farenheit = 1f;
            float expected = 255.93f;
            float actual = float.Parse(ConvertTemperature.FarenheitToKelvin(farenheit).ToString("#.##"));
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void KelvinToFarenheitTest()
        {
            float kelvin = 1f;
            float expected = -457.87f;
            float actual = float.Parse(ConvertTemperature.KelvinToFarenheit(kelvin).ToString("#.##"));
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CelsiusEqualToFarenheit()
        {
            float celsius = -40f;
            float expected = -40f;
            float actual = ConvertTemperature.CelsiusToFarenheit(celsius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FarenheitEqualToCelsius()
        {
            float farenheit = -40f;
            float expected = -40f;
            float actual = ConvertTemperature.FarenheitToCelsius(farenheit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointCtoF()
        {
            float celsius = 100f;
            float expected = 212f;
            float actual = ConvertTemperature.CelsiusToFarenheit(celsius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointFtoC()
        {
            float farenheit = 212f;
            float expected = 100f;
            float actual = ConvertTemperature.FarenheitToCelsius(farenheit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointCtoK()
        {
            float celsius = 100f;
            float expected = 373.15f;
            float actual = ConvertTemperature.CelsiusToKelvin(celsius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointKtoC()
        {
            float kelvin = 373.15f;
            float expected = 100f;
            float actual = ConvertTemperature.KelvinToCelsius(kelvin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointFtoK()
        {
            float farenheit = 212f;
            float expected = 373.15f;
            float actual = ConvertTemperature.FarenheitToKelvin(farenheit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BoilingPointKtoF()
        {
            float kelvin = 373.15f;
            float expected = 212f;
            float actual = ConvertTemperature.KelvinToFarenheit(kelvin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointCtoF()
        {
            float celsius = 0f;
            float expected = 32f;
            float actual = ConvertTemperature.CelsiusToFarenheit(celsius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointFtoC()
        {
            float farenheit = 32f;
            float expected = 0f;
            float actual = ConvertTemperature.FarenheitToCelsius(farenheit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointCtoK()
        {
            float celsius = 0f;
            float expected = 273.15f;
            float actual = ConvertTemperature.CelsiusToKelvin(celsius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointKtoC()
        {
            float kelvin = 273.15f;
            float expected = 0f;
            float actual = ConvertTemperature.KelvinToCelsius(kelvin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointFtoK()
        {
            float farenheit = 32f;
            float expected = 273.15f;
            float actual = ConvertTemperature.FarenheitToKelvin(farenheit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FreezingPointKtoF()
        {
            float kelvin = 273.15f;
            float expected = 32f;
            float actual = ConvertTemperature.KelvinToFarenheit(kelvin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroCtoF()
        {
            float celsius = -273.15f;
            float expected = -459.67f;
            float actual = float.Parse(ConvertTemperature.CelsiusToFarenheit(celsius).ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroFtoC()
        {
            float farenheit = -459.67f;
            float expected = -273.15f;
            float actual = float.Parse(ConvertTemperature.FarenheitToCelsius(farenheit).ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroCtoK()
        {
            float celsius = -273.15f;
            float expected = 0f;
            float actual = float.Parse(ConvertTemperature.CelsiusToKelvin(celsius).ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroKtoC()
        {
            float kelvin = 0f;
            float expected = -273.15f;
            float actual = float.Parse(ConvertTemperature.KelvinToCelsius(kelvin).ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroFtoK()
        {
            float farenheit = -459.67f;
            float celsius = float.Parse(ConvertTemperature.FarenheitToCelsius(farenheit).ToString());
            float expected = 0f;
            float actual = float.Parse(ConvertTemperature.CelsiusToKelvin(celsius).ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AbsoluteZeroKtoF()
        {
            float kelvin = 0f;
            float expected = -459.67f;
            float actual = float.Parse(ConvertTemperature.KelvinToFarenheit(kelvin).ToString());
            Assert.AreEqual(expected, actual);
        }
    }
}
