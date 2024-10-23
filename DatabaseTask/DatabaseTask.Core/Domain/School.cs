using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class School
    {
        [Key]
        public string? SchoolName { get; set; }

        public string? SchoolAddress { get; set; }
    }
}
