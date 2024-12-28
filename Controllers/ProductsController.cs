using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSearchApi.Models;

namespace ProductSearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            //The data below will be coming from a database in a real project.
            var metros = new[]
    {
        new Metro { MetroAreaID = 1006, MetroAreaTitle = "Richmond", MetroAreaStateAbr = "VA", MetroAreaStateName = "Virginia" },
        new Metro { MetroAreaID = 1007, MetroAreaTitle = "Atlanta", MetroAreaStateAbr = "GA", MetroAreaStateName = "Georgia" },
        new Metro { MetroAreaID = 1008, MetroAreaTitle = "Charleston", MetroAreaStateAbr = "SC", MetroAreaStateName = "South Carolina" }
    };

            var projects = new[]
            {
        new Project { ProjectGroupID = 23, MetroAreaID = 1007, FullName = "Edgewater", Status = "a" },
        new Project { ProjectGroupID = 25, MetroAreaID = 1007, FullName = "Inwood", Status = "a" },
        new Project { ProjectGroupID = 41, MetroAreaID = 1008, FullName = "Estuary at Bowen Village", Status = "a" },
        new Project { ProjectGroupID = 43, MetroAreaID = 1008, FullName = "Mixson", Status = "i" },
        new Project { ProjectGroupID = 47, MetroAreaID = 1008, FullName = "Oldfield", Status = "a" }
    };

            var products = new[]
            {
        new Product { ProjectName = "Edgewater", ProductID = "Y58", ProjectGroupID = 23, ProductName = "The Prescott" },
        new Product { ProjectName = "Edgewater 50", ProductID = "980", ProjectGroupID = 23, ProductName = "The Davis" },
        new Product { ProjectName = "Edgewater 50", ProductID = "E15", ProjectGroupID = 23, ProductName = "The Amelia" },
        new Product { ProjectName = "Edgewater 50", ProductID = "Y54", ProjectGroupID = 23, ProductName = "The Lockwood" },
        new Product { ProjectName = "Estuary", ProductID = "U68", ProjectGroupID = 41, ProductName = "The Stono" },
        new Product { ProjectName = "Estuary", ProductID = "1601", ProjectGroupID = 41, ProductName = "The Moultrie" },
        new Product { ProjectName = "Inwood SFD", ProductID = "980", ProjectGroupID = 25, ProductName = "The Dupree" },
        new Product { ProjectName = "Inwood SFD", ProductID = "E15", ProjectGroupID = 25, ProductName = "Inwood" },
        new Product { ProjectName = "Mixson", ProductID = "1674", ProjectGroupID = 43, ProductName = "The Stella" },
        new Product { ProjectName = "Oldfield", ProductID = "1665", ProjectGroupID = 47, ProductName = "The Tidalview" },
        new Product { ProjectName = "Oldfield", ProductID = null, ProjectGroupID = 47, ProductName = null }
    };

            // Perform the join server-side
            var result = from p in products
                         join proj in projects on p.ProjectGroupID equals proj.ProjectGroupID
                         join m in metros on proj.MetroAreaID equals m.MetroAreaID
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
