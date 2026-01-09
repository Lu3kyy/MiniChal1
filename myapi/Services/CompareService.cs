namespace myapi.Services
{
    public class CompareService : ICompareService
    {
        public (string firstStatement, string secondStatement) GetComparisons(int first, int second)
        {
            string cmp1 = first > second ? "greater than" : first < second ? "less than" : "equal to";
            string cmp2 = second > first ? "greater than" : second < first ? "less than" : "equal to";

            var s1 = $"The first number {first} is {cmp1} the second number {second}.";
            var s2 = $"The second number {second} is {cmp2} the first number {first}.";

            return (s1, s2);
        }
    }
}
