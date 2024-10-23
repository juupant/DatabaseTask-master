using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Group_Supervisor
    {
        [Key]
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public int Phone { get; set; }

        public int ClassId { get; set; }

    }
}
