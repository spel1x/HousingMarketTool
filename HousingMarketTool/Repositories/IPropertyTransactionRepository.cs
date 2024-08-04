using HousingMarketTool.Models;

namespace HousingMarketTool.Repositories
{
    public interface IPropertyTransactionRepository
    {
        IEnumerable<PropertyTransaction> GetAllTransactions();
    }
}
