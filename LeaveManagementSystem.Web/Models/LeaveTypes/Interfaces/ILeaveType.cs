using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public interface ILeaveType
    {
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}