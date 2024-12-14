using Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.EntityModels
{
    public class ContractEntity : BaseEntity
    {
        [MaxLength(50)]
        public string ContractNo { get; set; }
        public ContractType ContractType { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public Status Status { get; set; }
    }
}
