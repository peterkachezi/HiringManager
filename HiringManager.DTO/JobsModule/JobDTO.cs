﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.DTO.JobsModule
{
    public class JobDTO
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}