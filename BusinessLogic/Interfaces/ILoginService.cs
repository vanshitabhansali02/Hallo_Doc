using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ILoginService
    {
        bool LoginUser(string username, string password);

        // Add other relevant methods for your login service
    }
}
