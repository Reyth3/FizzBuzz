namespace WC_FizzBuzz.Library
{
    public interface IFizzBuzzCheck
    {
        string Message { get; }

        bool ExecuteFor(int n);
    }
}