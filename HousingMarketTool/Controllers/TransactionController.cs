using HousingMarketTool.Repositories;
using HousingMarketTool.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HousingMarketTool.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IPropertyTransactionRepository _propertyTransactionRepository;

        public TransactionController(IPropertyTransactionRepository propertyTransactionRepository)
        {
            _propertyTransactionRepository = propertyTransactionRepository;
        }
        public IActionResult Properties()
        {
            PropertiesViewModel propertiesViewModel = new(_propertyTransactionRepository.GetAllTransactions(), "Uk Properties in 2023");

            return View(propertiesViewModel);
        }
    }
}
