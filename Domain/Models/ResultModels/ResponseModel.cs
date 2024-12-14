using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.ResultModels
{
    public class ResponseModel
    {
        public int Code { get; set; }
        public dynamic Data { get; set; }
    }
}
