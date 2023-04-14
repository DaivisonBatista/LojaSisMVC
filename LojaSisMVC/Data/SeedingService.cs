using LojaSisMVC.Models;
namespace LojaSisMVC.Data
{
    public class SeedingService
    {
        private LojaSisMVCContext _context;

        public SeedingService(LojaSisMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            Departments d1 = new Departments(1, "Mercearia");
            Departments d2 = new Departments(2, "Padaria");
            Departments d3 = new Departments(3, "Açougue");

            _context.AddRange(d1, d2, d3);
            _context.SaveChanges();
        }
    }
}
