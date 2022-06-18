using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.DTO.EmployeeModule
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentState { get; set; }
        public bool EnableSendUpdates { get; set; }
        public bool IsResumeUploaded { get; set; }
    }
}
