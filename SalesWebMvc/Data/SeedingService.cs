using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    //Construindo a base de dados
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed() // essa operação é responsável que vai gerar a população da base de dados
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; //O banco de dados já foi populado
            }

            Department d1 = new Department(1, "Eletronicos", 56.00);
            Department d2 = new Department(2, "Computadores", 5678.00);
            Department d3 = new Department(3, "NootBook", 3456.00);
            Department d4 = new Department(4, "SamrtTV", 765.00);
            // é possivel criar dessa forma
            // Department d5 = new Department { Id = 5, Name = "Yaho", Sellers = Seller , Valor = 90.00}

            Seller s1 = new Seller(1, "Thiago Santos", "thi@gmail.com", new DateTime(1999, 5, 22), 1900.00, d1);
            Seller s2 = new Seller(2, "Fernando Nery", "neri@gmail.com", new DateTime(1999, 7, 28), 6789.00, d2);
            Seller s3 = new Seller(3, "Gabriel Moreira", "gabi@gmail.com", new DateTime(1998, 6, 21), 5678.00, d3);
            Seller s4 = new Seller(4, "Hugo Moura", "hugo@gmail.com", new DateTime(1998, 2, 19), 7890.00, d4);
            Seller s5 = new Seller(5, "Vanessa Lima", "van@hotmail.com", new DateTime(1999, 12, 28), 5468.00, d1);
            Seller s6 = new Seller(6, "Manuela Silva", "manu@hotmail.com", new DateTime(1996, 8, 20), 5679.00, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(1999, 9, 23), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(1999, 1, 21), 11000.00, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(1999, 2, 18), 11000.00, SaleStatus.Billed, s5);
            SalesRecord r4 = new SalesRecord(4, new DateTime(1999, 4, 12), 11000.00, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(1999, 5, 11), 11000.00, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(1999, 10, 19), 11000.00, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(1998, 12, 15), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(1999, 7, 10), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(1999, 3, 4), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(1998, 4, 8), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(1997, 7, 29), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(1999, 6, 30), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(1999, 3, 27), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(1999, 2, 25), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(1999, 2, 28), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(1996, 4, 28), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r17 = new SalesRecord(17, new DateTime(1999, 2, 16), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(1999, 8, 12), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2000, 7, 27), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2001, 2, 28), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(1992, 1, 22), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(1993, 3, 28), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r23 = new SalesRecord(23, new DateTime(1991, 2, 21), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r24 = new SalesRecord(24, new DateTime(1993, 9, 22), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r25 = new SalesRecord(25, new DateTime(1997, 3, 29), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(1994, 12, 15), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r27 = new SalesRecord(27, new DateTime(1992,8, 19), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(1992, 11, 23), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r29 = new SalesRecord(29, new DateTime(1992, 9, 17), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r30 = new SalesRecord(30, new DateTime(1996, 9, 21), 11000.00, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5,
                r6, r7, r8, r9, r10, r11, r12, r13, r14, r15,
                r16, r17, r18, r19, r20, r21, r22, r23, r24,
                r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();

        }
    }
}


