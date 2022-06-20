using HiringManager.BLL.Repositories.JobsModule;
using Microsoft.AspNetCore.Mvc;

namespace HiringManager.Controllers
{

    public class JobListingController : Controller
    {
        private readonly IJobRepository jobRepository;
        public JobListingController(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var jobs = await jobRepository.GetAll();

                return View(jobs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
