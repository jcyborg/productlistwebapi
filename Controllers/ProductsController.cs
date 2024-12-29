using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSearchApi.Models;
using ProductSearchApi.Services;

namespace ProductSearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MetroService _metroService;
        private readonly ProjectService _projectService;
        private readonly ProductService _productService;

        public ProductsController(MetroService metroService, ProjectService projectService, ProductService productService)
        {
            _metroService = metroService;
            _projectService = projectService;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var metros = _metroService.GetMetros();
            var projects = _projectService.GetProjects();
            var products = _productService.GetProducts();

            var result = from p in products
                         join proj in projects on p.ProjectGroupID equals proj.ProjectGroupID
                         join m in metros on proj.MetroAreaID equals m.MetroAreaID
                         orderby p.ProductName
                         select new
                         {
                             p.ProductName,
                             p.ProductID,
                             m.MetroAreaTitle,
                             proj.FullName,
                             p.ProjectGroupID
                         };

            return Ok(result);
        }

    }
}
