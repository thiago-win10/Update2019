using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task <List<Seller>> FindAllAsync() // Esse método List(GET) é tipo no python: Seller.objects.all()
        {
            return await _context.Seller.ToListAsync(); // esse construtor traz o GET dos dados do banco de dados seller 
        }
        public async Task InsertAsync(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
           await _context.SaveChangesAsync(); //seller instanciado para Departamento

        }
         public async Task<Seller> FindByIdAsync(int? id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = _context.Seller.Find(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                throw new IntegrityException("Nao pode Deletar");
            }
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not Found");
            }
            try
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();

            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
