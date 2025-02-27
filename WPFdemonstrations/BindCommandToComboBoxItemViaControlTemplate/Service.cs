using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindCommandToComboBoxItemViaControlTemplate
{
    public interface ICustomerStoreService
    {
        List<string> GetAll();
    }

    public class DbCustomerStoreService : ICustomerStoreService
    {
        public List<string> GetAll()
        {
            return ["123", "234", "345",];
        }
    }
}
