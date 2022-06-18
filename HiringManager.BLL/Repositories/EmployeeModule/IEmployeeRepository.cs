using HiringManager.DTO.EmployeeModule;

namespace HiringManager.BLL.Repositories.EmployeeModule
{
    public interface IEmployeeRepository
    {
        Task<EmployeeDTO> Create(EmployeeDTO employeeDTO);
        Task<EmployeeDTO> Update(EmployeeDTO employeeDTO);
        Task<List<EmployeeDTO>> GetAll();
    }
}