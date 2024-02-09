    using BusinessLogic.Interfaces;
    using DataAccess.ViewModel;
    using DataAccess.DataModels;
    using DataAccess.DataContext;
    
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BusinessLogic.Services
    {
        public class LoginService : ILoginService
        {

            private readonly ApplicationDbContext _db;

            public LoginService(ApplicationDbContext db)
            {
                _db = db;
            }

            public bool LoginData(LoginUser loginuser)
            {
                 
            
                return _db.Aspnetusers.Any(x => x.Email == loginuser.email && x.Passwordhash == loginuser.password);

            }


        }
    }

