using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.EntityModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid TransactionId { get; set; }
        [MaxLength(50)]
        public string CreateBy{ get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

    }
}
