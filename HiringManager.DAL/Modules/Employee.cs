using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.DAL.Modules
{
    public partial class Employee
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

