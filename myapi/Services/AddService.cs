namespace myapi.Services
{
    public class AddService : IAddService
    {
        public string GetSum(int a, int b)
        {
            var sum = a + b;
            return $"The sum of {a} and {b} is {sum}.";
        }
    }
}
