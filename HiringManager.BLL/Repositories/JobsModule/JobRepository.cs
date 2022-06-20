using AutoMapper;
using HiringManager.DAL.Modules;
using HiringManager.DTO.JobsModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.BLL.Repositories.JobsModule
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationDbContext context;

        private readonly IMapper mapper;
        public JobRepository(IMapper mapper, ApplicationDbContext context)
        {
            this.context = context;

            this.mapper = mapper;
        }
        public async Task<JobDTO> Create(JobDTO jobDTO)
        {
            try
            {
                jobDTO.CreateDate = DateTime.Now;

                var slot = mapper.Map<Job>(jobDTO);

                context.Jobs.Add(slot);

                await context.SaveChangesAsync();

                return jobDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                bool result = false;

                var slot = await context.Jobs.FindAsync(Id);

                if (slot != null)
                {
                    context.Jobs.Remove(slot);

                    await context.SaveChangesAsync();

                    return true;
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public async Task<List<JobDTO>> GetAll()
        {
            try
            {
                var data = await context.Jobs.ToListAsync();

                var jobs = mapper.Map<List<Job>, List<JobDTO>>(data);

                return jobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
        public async Task<JobDTO> GetById(Guid Id)
        {
            try
            {
                var data = await context.Jobs.FindAsync(Id);

                var slot = mapper.Map<JobDTO>(data);

                return slot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
        public async Task<JobDTO> Update(JobDTO jobDTO)
        {
            try
            {
                var getData = await context.Jobs.FindAsync(jobDTO.Id);

                if (getData != null)
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        var data = getData;

                        mapper.Map(jobDTO, data);

                        context.Entry(data).State = EntityState.Modified;

                        transaction.Commit();

                        await context.SaveChangesAsync();

                    }

                    return jobDTO;
                }

                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }

}
