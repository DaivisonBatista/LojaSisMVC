using LojaSisMVC.Models.enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LojaSisMVC.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        [Precision(18, 2)]
        public decimal BaseSalary { get; set; }
        public Departments Department { get; set; } = null!;
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string nome, string email, DateTime birtDate, decimal baseSalary, Departments department)
        {
            ID = iD;
            Nome = nome;
            Email = email;
            BirthDate = birtDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public decimal TotalSales(DateTime Inicial, DateTime Final)
        {
            return Sales.Where(sr => sr.Date >= Inicial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
