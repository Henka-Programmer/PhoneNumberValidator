namespace PhoneNumber.Validator
{
    public interface IPhoneNumberValidator
    {
        IPhoneNumber FromString(string phoneMumber);
    }
}
