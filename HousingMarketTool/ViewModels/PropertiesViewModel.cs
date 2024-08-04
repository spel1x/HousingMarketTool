using HousingMarketTool.Models;

namespace HousingMarketTool.ViewModels
{
    public class PropertiesViewModel
    {
        public string? Title { get; }
        public IEnumerable<PropertyTransaction> PropertyTransactions { get; }

        public PropertiesViewModel(IEnumerable<PropertyTransaction> propertyTransactions, string? title) 
        { 
            PropertyTransactions = propertyTransactions;
            Title = title;
        }
    }
}
