using EmployeeMgtSysApi.Models;

namespace EmployeeMgtSysApi.Repositories.Interfaces;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee> FindByIdAsync(Guid id);
    Task AddEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(int id);
    Task<Employee> GetByIdAsync(int id);
    Task<Employee> UpdateEmployeeAsync(Employee employee);

        
}
