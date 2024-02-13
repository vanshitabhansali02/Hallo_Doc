    using BusinessLogic.Interfaces;
    using DataAccess.ViewModel;
    using DataAccess.DataModels;
    using DataAccess.DataContext;
    using System.Windows;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

    namespace BusinessLogic.Services
    {
        public class LoginService : ILoginService
        {
        private readonly ApplicationDbContext _db;




        // /p/ublic User LoginData(LoginUser loginuser)
        //   {





        public bool LoginData(LoginUser loginuser)
        {


            return _db.Aspnetusers.Any(x => x.Email == loginuser.email && x.Passwordhash == loginuser.password);


        }

        //     //return _db.Aspnetusers.Any(x => x.Email == loginuser.email && x.Passwordhash == loginuser.password);

        // }
        //public bool UserData(LoginUser loginuser)
        //{


        //    User usr = _db.Aspnetusers.Where(x => x.Email==loginuser.email && x.Passwordhash==loginuser.password).FirstOrDefault();
        //    if(usr == null) { 
        //        return false
        //    }
        //    if(u)
        //}

        public bool LoginData(LoginUser loginuser)
        {
            // I don't validate password here (see TODO below)
            var user = _db.Aspnetusers.FirstOrDefault(u => u.Email == loginuser.email && u.Passwordhash == loginuser.password);

            return true;
           

            

            
        }
       
        //public bool LoginData(LoginUser loginuser)
        //{


        //    if(user == null)
        //    {
        //        return false;
        //    }
        //    if (user != null)
        //    {

        //    }
        //}
        //public void main()
        //{
        //    User fetch = LoginData();
        //    if(fetch != null)
        //    {

        //    }
        //    else
        //    {

        //    }



    }


        }
    

