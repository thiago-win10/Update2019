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
         public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
