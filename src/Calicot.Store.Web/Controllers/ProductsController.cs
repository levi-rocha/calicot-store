using Calicot.Store.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calicot.Store.Web.Controllers
{
    public class ProductsController : StoreControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public async Task<ActionResult> Index(GetAllProductsInput input)
        {
            var output = await _productAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }

        public async Task<ActionResult> Create()
        {

            return View(new CreateProductViewModel());
        }
    }
}
