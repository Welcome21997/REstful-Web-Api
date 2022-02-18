using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Repository
{
   public interface IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee> DeleteEmployee(int Id);
        public Task<Employee> GetEmployee(int Id);
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> UpdateEmployee(Employee employee);

    }
}
