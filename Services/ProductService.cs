using ProductSearchApi.Models;

namespace ProductSearchApi.Services
{
    public class ProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new[]
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
        }
    }
}
