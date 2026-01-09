namespace myapi.Services
{
    public interface ICompareService
    {
        (string firstStatement, string secondStatement) GetComparisons(int first, int second);
    }
}
