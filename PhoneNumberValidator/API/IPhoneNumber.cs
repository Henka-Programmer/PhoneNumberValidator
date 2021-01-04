namespace PhoneNumber.Validator
{
    public interface IPhoneNumber
    {
        IPhoneNumber WithMask(string mask);
        bool IsValid();
        IPhoneNumber IsRequired();
        IPhoneNumber IsOptional();
    }
}
