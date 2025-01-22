using CompanyManager.Logic.DataContext;
using CompanyManager.Logic.Models;

namespace CompanyManager.Logic.Contracts
{
        interface IContext : IDisposable
        {
                DbSet<Employee> EmployeeSet { get; }
                int SaveChanges( );
        }
}