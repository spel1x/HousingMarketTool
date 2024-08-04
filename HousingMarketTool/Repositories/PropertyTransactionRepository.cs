using HousingMarketTool.Models;

namespace HousingMarketTool.Repositories
{
    public class PropertyTransactionRepository : IPropertyTransactionRepository
    {
        public IEnumerable<PropertyTransaction> GetAllTransactions()
        {
            return new List<PropertyTransaction>
            {
                new PropertyTransaction
                {
                    Id = 1,
                    BuildingName = "Building A",
                    County = "County X",
                    DateTime = DateTime.Now,
                    EstateType = "Estate Type 1",
                    NewBuild = true,
                    PostCode = "12345",
                    Price = 100000,
                    PropertyType = "Property Type 1"
                },
                new PropertyTransaction
                {
                    Id = 2,
                    BuildingName = "Building B",
                    County = "County Y",
                    DateTime = DateTime.Now,
                    EstateType = "Estate Type 2",
                    NewBuild = false,
                    PostCode = "54321",
                    Price = 200000,
                    PropertyType = "Property Type 2"
                },
                new PropertyTransaction
                {
                    Id = 3,
                    BuildingName = "Building C",
                    County = "County Z",
                    DateTime = DateTime.Now,
                    EstateType = "Estate Type 3",
                    NewBuild = true,
                    PostCode = "67890",
                    Price = 300000,
                    PropertyType = "Property Type 3"
                },
                new PropertyTransaction
                {
                    Id = 4,
                    BuildingName = "Building D",
                    County = "County W",
                    DateTime = DateTime.Now,
                    EstateType = "Estate Type 4",
                    NewBuild = false,
                    PostCode = "98765",
                    Price = 400000,
                    PropertyType = "Property Type 4"
                }
            };
           }
    }
}
