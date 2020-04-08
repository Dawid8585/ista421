using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
