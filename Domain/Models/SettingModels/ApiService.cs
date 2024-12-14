using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.SettingModels
{
    public class ApiService
    {
        public CustomerServiceModel Customer { get; set; }
    }

    public class BaseApiServiceModel
    {
        public virtual string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SignIn { get; set; }
    }
    public class CustomerServiceModel : BaseApiServiceModel
    {
        public string InsertCustomer { get; set; }

    }
}
