namespace HousingMarketTool.Models
{
    public class PropertyTransaction
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string County { get; set; }
        public DateTime DateTime { get; set; }
        public string? District { get; set; }
        public string EstateType { get; set; }
        public string? Locality { get; set; }
        public bool NewBuild { get; set; }
        public string PostCode { get; set; }
        public int Price { get; set; }
        public string PropertyType { get; set; }
        public string? SecondaryName { get; set; }
        public string? Street { get; set; }
        public string? Town { get; set; }
    }
}
