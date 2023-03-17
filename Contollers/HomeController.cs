using Microsoft.AspNetCore.Mvc;
using Eyac_SportsStore.Models;

namespace Eyac_SportsStore.Contollers
{
    public class HomeController: Controller
    {        
        private IStoreRepository repository;
        public int pageSize = 4;
        public HomeController(IStoreRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index(int productPage = 1)
            => View(repository.Products
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * pageSize)
            .Take(pageSize));
    }
}
