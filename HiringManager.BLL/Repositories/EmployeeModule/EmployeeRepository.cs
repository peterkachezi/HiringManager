using AutoMapper;
using HiringManager.DAL.Modules;
using HiringManager.DTO.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.BLL.Repositories.EmployeeModule
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;

        private readonly IMapper mapper;

   
        public EmployeeRepository(IMapper mapper, ApplicationDbContext context)
        {
            this.context = context;

            this.mapper = mapper;
        }

        public async Task<EmployeeDTO> Create(EmployeeDTO employeeDTO)
        {
            try
            {
                var employee = mapper.Map<Employee>(employeeDTO);

                context.Employees.Add(employee);

                await context.SaveChangesAsync();

                return employeeDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public Task<List<EmployeeDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDTO> Update(EmployeeDTO employeeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
