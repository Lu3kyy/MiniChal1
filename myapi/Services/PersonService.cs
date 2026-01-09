namespace myapi.Services
{
    public class PersonService : IPersonService
    {
        public string GetIntro(string name, string wakeTime)
        {
            return $"{name} woke up at {wakeTime}.";
        }
    }
}
