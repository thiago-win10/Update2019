using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Valor { get; set; }
        [NotMapped]
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name, double valor)
        {
            Id = id;
            Name = name;
            Valor = valor;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
   
}
