using ProductSearchApi.Models;

namespace ProductSearchApi.Services
{
    public class ProjectService
    {
        public IEnumerable<Project> GetProjects()
        {
            return new[]
            {
                new Project { ProjectGroupID = 23, MetroAreaID = 1007, FullName = "Edgewater", Status = "a" },
                new Project { ProjectGroupID = 25, MetroAreaID = 1007, FullName = "Inwood", Status = "a" },
                new Project { ProjectGroupID = 41, MetroAreaID = 1008, FullName = "Estuary at Bowen Village", Status = "a" },
                new Project { ProjectGroupID = 43, MetroAreaID = 1008, FullName = "Mixson", Status = "i" },
                new Project { ProjectGroupID = 47, MetroAreaID = 1008, FullName = "Oldfield", Status = "a" }
            };
        }
    }
}
