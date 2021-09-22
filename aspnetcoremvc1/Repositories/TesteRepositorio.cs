using System.Collections.Generic;
using aspnetcoremvc1.Interfaces;
using aspnetcoremvc1.Models;

namespace aspnetcoremvc1.Repositories
{
    public class TesteRepositorio : IRepository
    {
        private static Produto[] Dados = new Produto[]{
            new Produto{ProdutoId = 10, Nome = "Televisão", Categoria = "Eletronicos", Preco = 2000.0m},
            new Produto{ProdutoId = 10, Nome = "Laptop", Categoria = "Informatica", Preco = 3000.0m},
            new Produto{ProdutoId = 10, Nome = "Celular", Categoria = "Eletronicos", Preco = 4000.0m},
        };

        public IEnumerable<Produto> Produtos => Dados;
    }
}