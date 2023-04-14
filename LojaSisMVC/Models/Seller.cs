using LojaSisMVC.Models.enums;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LojaSisMVC.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirtDate { get; set; }
        public double BaseSalary { get; set; }
        public Departments Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string nome, string email, DateTime birtDate, double baseSalary, Departments department)
        {
            ID = iD;
            Nome = nome;
            Email = email;
            BirtDate = birtDate;
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
        public double TotalSales(DateTime Inicial, DateTime Final)
        {
            return Sales.Where(sr => sr.Date >= Inicial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
