using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneNumber.Validator.Tests
{
    [TestClass]
    public class PhoneNumberValidatorTest
    {
        [TestMethod]
        public void Test_MobilisNumberWithoutAreaCode_Valid()
        {
            var validator = new PhoneNumberValidator()
                .FromString("0662175032")
                .WithMask("06########");
            Assert.IsTrue(validator.IsValid());
        }

        [TestMethod]
        public void Test_MobilisNumberWithAreaCode_Invalid()
        {
            var validator = new PhoneNumberValidator()
                .FromString("00213(0)0662175032")
                .WithMask("00213(0)6########");
            Assert.IsFalse(validator.IsValid());
        }

        [TestMethod]
        public void Test_DjezzyNumberWithAreaCode_Valid()
        {
            var validator = new PhoneNumberValidator()
                .FromString("+213770175032")
                .WithMask("002137########")
                .WithMask("+2137########");
            Assert.IsTrue(validator.IsValid());
        }

        [TestMethod]
        public void Test_MobilisNumberOptional_Valid()
        {
            var validator = new PhoneNumberValidator()
               .FromString("")
               .IsOptional()
               .WithMask("06########")
               .WithMask("00213(0)6########")
               .WithMask("002136########")
               .WithMask("+2136########")
               .WithMask("+213(0)6########");
            Assert.IsTrue(validator.IsValid());
        }

        [TestMethod]
        public void Test_MobilisNumberOptional_InValid()
        {
            var validator = new PhoneNumberValidator()
               .FromString("00213(0)07505050")
               .IsOptional()
               .WithMask("06########")
               .WithMask("00213(0)6########")
               .WithMask("002136########")
               .WithMask("+2136########")
               .WithMask("+213(0)6########");
            Assert.IsFalse(validator.IsValid());
        }
    }
}
