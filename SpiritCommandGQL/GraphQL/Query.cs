using HotChocolate;
using SpiritCommandGQL.Data;
using SpiritCommandGQL.Models;
using System.Linq;

namespace SpiritCommandGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Kernel> GetKernels([Service] AppDbContext context)
        {
            return context.Kernels;
        }
    }
}
