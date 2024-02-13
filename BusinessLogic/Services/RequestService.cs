using BusinessLogic.Interfaces;
using DataAccess.DataContext;
using DataAccess.DataModels;
using DataAccess.ViewModel;
using System;
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

        public void PatientData(PatientReq patientmodel)
        
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
          //  var dob = patientmodel.BirthDate.ToString();
=======
           // var dob = patientmodel.BirthDate.ToString();

>>>>>>> commitvalidation ongoing9-2 commit

            Requestclient requestclient = new Requestclient();

<<<<<<< HEAD
          

            requestclient.Requestid = 8;    
=======


            requestclient.Requestid = 1;
>>>>>>> commitvalidation ongoing9-2 commit
            requestclient.Firstname = patientmodel.Firstname;
            requestclient.Lastname = patientmodel.Lastname;
            requestclient.Phonenumber = patientmodel.Phonenumber;
<<<<<<< HEAD
            requestclient.Email=patientmodel.Email;
          
            requestclient.Intyear = patientmodel.BirthDate.Year;
=======
            requestclient.Email = patientmodel.Email;

            //requestclient.Intyear = patientmodel.BirthDate.Year;
>>>>>>> commitvalidation ongoing9-2 commit
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

        public void BusinessData(BusinessReq businessreq)
        {
            Request req = new Request();
            req.Firstname = businessreq.bFirstname;
            req.Requesttypeid = 1;
            req.Lastname = businessreq.bLastname;
            req.Phonenumber = businessreq.bPhonenumber;
            req.Email = businessreq.bEmail;
            req.Status = 4;
            req.Createddate = DateTime.Now;
            req.Isurgentemailsent = new BitArray(new bool[1]);
            _db.Requests.Add(req);
             _db.SaveChanges();



            Requestclient requestclient = new Requestclient();
            requestclient.Requestid = 1;
            requestclient.Firstname = businessreq.Firstname;
            requestclient.Lastname= businessreq.Lastname;
            requestclient.Phonenumber=businessreq.Phonenumber;
            _db.Requestclients.Add(requestclient);
            _db.SaveChanges();

        }
        public void ConciergeData(ConciergeReq conciergereq)
        {
            Request req = new Request();
            req.Firstname = conciergereq.cFirstname; 
            req.Requesttypeid = 1;
            req.Lastname = conciergereq.cLastname;
            req.Phonenumber = conciergereq.cPhonenumber;
            req.Email = conciergereq.cEmail;
            req.Status = 4;
            req.Createddate = DateTime.Now;
            req.Isurgentemailsent = new BitArray(new bool[1]);
            _db.Requests.Add(req);
            _db.SaveChanges();

            Requestclient requestclient = new Requestclient();

            requestclient.Requestid = 1;
            requestclient.Firstname = conciergereq.Firstname;
            requestclient.Lastname = conciergereq.Lastname;
            requestclient.Phonenumber = conciergereq.Phonenumber;
            _db.Requestclients.Add(requestclient);
            _db.SaveChanges();

            Concierge concierge = new Concierge();






        }





       


        //        Requestclient requestclient = new Requestclient();
        //        requestclient.Requestid = 8;
        //        requestclient.Firstname = conciergemodel.Firstname;
        //        requestclient.Lastname = conciergemodel.Lastname;
        //        requestclient.Phonenumber = conciergemodel.Phonenumber;
        //        requestclient.Email = conciergemodel.Email;

        //        requestclient.Intyear = conciergemodel.BirthDate.Year;
        //        requestclient.Regionid = 1;
        //        _db.Requestclients.Add(requestclient);
        //        _db.SaveChanges();


        //        Concierge concierge = new Concierge();
        //        concierge.City = conciergemodel.City;
        //        concierge.Street = conciergemodel.Street;
        //        concierge.
        //    }
        //}
    }
}
