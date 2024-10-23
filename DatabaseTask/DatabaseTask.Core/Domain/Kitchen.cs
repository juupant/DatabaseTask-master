using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Kitchen
    {
        [Key]
        public DateOnly MenuDate { get; set; }

        public string? Food { get; set; }

        public int CouponId { get; set; }
    }
}
