using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models.BaseEntity
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string UserId { get; set; }
        public string LastUpdated { get; set; }
    }
}
