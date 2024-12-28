using ProductSearchApi.Models;

namespace ProductSearchApi.Services
{
    public class MetroService
    {
        public IEnumerable<Metro> GetMetros()
        {
            return new[]
            {
                new Metro { MetroAreaID = 1006, MetroAreaTitle = "Richmond", MetroAreaStateAbr = "VA", MetroAreaStateName = "Virginia" },
                new Metro { MetroAreaID = 1007, MetroAreaTitle = "Atlanta", MetroAreaStateAbr = "GA", MetroAreaStateName = "Georgia" },
                new Metro { MetroAreaID = 1008, MetroAreaTitle = "Charleston", MetroAreaStateAbr = "SC", MetroAreaStateName = "South Carolina" }
            };
        }
    }
}
