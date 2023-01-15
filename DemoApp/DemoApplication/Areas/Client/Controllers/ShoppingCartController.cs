using DemoApplication.Areas.Client.ViewModels.Basket;
using DemoApplication.Areas.Client.ViewModels.Home.Index;
using DemoApplication.Areas.Client.ViewModels.ShoppingCart;
using DemoApplication.Contracts.File;
using DemoApplication.Database;
using DemoApplication.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DemoApplication.Areas.Client.Controllers
{
    [Area("client")]
    [Route("shopping")]
    public class ShoppingCartController : Controller
    {
        private readonly DataContext _dbContext;

        public ShoppingCartController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("list", Name = "shopping-list")]
        public async Task<IActionResult> IndexAsync([FromServices] IFileService fileService)
        {
            var productsCookieValue = HttpContext.Request.Cookies["products"];
            var productsCookieViewModel = new List<ProductCookieViewModel>();
            if (productsCookieValue is not null)
            {
                productsCookieViewModel = JsonSerializer.Deserialize<List<ProductCookieViewModel>>(productsCookieValue);
            }

            return View(productsCookieViewModel);
        }



    }
}
