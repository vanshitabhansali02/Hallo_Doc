using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataModels;
using DataAccess.ViewModel;

namespace BusinessLogic.Interfaces  
{
    public interface ILoginService
    {
        public bool LoginData(LoginUser loginuser);
       



        // Add other relevant methods for your login service
    }
}
