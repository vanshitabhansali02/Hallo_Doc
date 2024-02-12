using BusinessLogic.Interfaces;
using DataAccess.DataContext;
using DataAccess.DataModels;
using DataAccess.ViewModel;
using System.Collections;

namespace BusinessLogic.Services
{
    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext _db;

        public RequestService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void PatientData(PatientReqModel patientmodel)
        {
            Request request = new Request();
            request.Firstname = patientmodel.Firstname;
            request.Lastname= patientmodel.Lastname;
            request.Phonenumber= patientmodel.Phonenumber;
            request.Createddate = DateTime.Now;
            request.Isurgentemailsent = new BitArray(new bool[1]);
            
            request.Requesttypeid = 1;
            request.Email = patientmodel.Email;

            request.Status = 3;
            _db.Requests.Add(request);
            _db.SaveChanges();

<<<<<<< HEAD
<<<<<<< HEAD
          //  var dob = patientmodel.BirthDate.ToString();
=======
           // var dob = patientmodel.BirthDate.ToString();

>>>>>>> commitvalidation ongoing9-2 commit
=======
          //  var dob = patientmodel.BirthDate.ToString();
>>>>>>> commit

            
            Requestclient requestclient = new Requestclient();

<<<<<<< HEAD
<<<<<<< HEAD
          

            requestclient.Requestid = 8;    
=======


            requestclient.Requestid = 1;
>>>>>>> commitvalidation ongoing9-2 commit
=======
          

            requestclient.Requestid = 8;    
>>>>>>> commit
            requestclient.Firstname = patientmodel.Firstname;
            requestclient.Lastname= patientmodel.Lastname;
            requestclient.Phonenumber = patientmodel.Phonenumber;
<<<<<<< HEAD
<<<<<<< HEAD
            requestclient.Email=patientmodel.Email;
          
            requestclient.Intyear = patientmodel.BirthDate.Year;
=======
            requestclient.Email = patientmodel.Email;

            //requestclient.Intyear = patientmodel.BirthDate.Year;
>>>>>>> commitvalidation ongoing9-2 commit
=======
            requestclient.Email=patientmodel.Email;
          
            requestclient.Intyear = patientmodel.BirthDate.Year;
>>>>>>> commit
            requestclient.Regionid = 1;
            _db.Requestclients.Add(requestclient);
            _db.SaveChanges();


            //user user = new user();
            //user.firstname = patientmodel.firstname;
            //user.lastname = patientmodel.lastname;
            //user.email = patientmodel.email;
            //user.street = patientmodel.street;
            //user.city = patientmodel.city;
            //user.state = patientmodel.state;
            //user.zip = patientmodel.zipcode;





        }
    }
}
