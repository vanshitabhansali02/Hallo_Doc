using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IRequestService
    {
        public void PatientData(PatientReq patientreq);
        public void BusinessData(BusinessReq businessreq);
       // public void ConciergeData(ConciergeReq conciergereq);

    }
}
