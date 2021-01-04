namespace PhoneNumber.Validator
{
    public class PhoneNumberValidator : IPhoneNumberValidator
    {
        public IPhoneNumber FromString(string phoneNumber)
        {
            return new PhoneNumber(phoneNumber);
        }
    }
}
