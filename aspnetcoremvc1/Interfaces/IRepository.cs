using System.Collections.Generic;
using aspnetcoremvc1.Models;

namespace aspnetcoremvc1.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos {get; }
    }
}