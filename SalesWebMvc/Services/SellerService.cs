using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll() // Esse método List(GET) é tipo no python: Seller.objects.all()
        {
            return _context.Seller.ToList(); // esse construtor traz o GET dos dados do banco de dados seller 
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges(); //seller instanciado para Departamento

        }
    }
}
