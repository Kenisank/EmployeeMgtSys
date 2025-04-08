using EmployeeMgtSysApi.Data;
using EmployeeMgtSysApi.Models;
using EmployeeMgtSysApi.Repositories.Interfaces;

namespace EmployeeMgtSysApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context) { _context = context; }
        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _context.Employees.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return _context.Employees;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return await GetByIdAsync(employee.Id);

        }
    }
}
