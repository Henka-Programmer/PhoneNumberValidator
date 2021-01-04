using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneNumber.Validator.Extensions;

namespace PhoneNumberValidator.Tests
{
    [TestClass]
    public class MaskExtensionTests
    {
        [TestMethod]
        public void Test_MasWithPrefix()
        {
            var mask = "0(0)6##";
            var value = "0(0)600";
            var cleanValue = "00600";
            Assert.AreEqual(value, cleanValue.Mask(mask));
        }
    }
}
