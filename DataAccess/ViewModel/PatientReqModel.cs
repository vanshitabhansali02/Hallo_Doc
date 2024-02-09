using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModel
{
    public  class PatientReqModel
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public string? Phonenumber { get; set; }
        public int Requestid { get; set; }
        public int Requesttypeid { get; set; }
        public short Status { get; set; }
        public DateTime Createddate { get; set; }
        public BitArray Isurgentemailsent { get; set; } = null!;
        public int Regionid { get; set; }
        public string? Notes { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zipcode { get; set; }
        public DateTime BirthDate {  get; set; }


    }
}
