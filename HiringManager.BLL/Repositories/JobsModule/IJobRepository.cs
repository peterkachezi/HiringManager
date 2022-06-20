using HiringManager.DTO.JobsModule;

namespace HiringManager.BLL.Repositories.JobsModule
{
    public interface IJobRepository
    {
        Task<JobDTO> Create(JobDTO jobDTO);
        Task<bool> Delete(Guid Id);
        Task<List<JobDTO>> GetAll();
        Task<JobDTO> GetById(Guid Id);
        Task<JobDTO> Update(JobDTO jobDTO);
    }
}