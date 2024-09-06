using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Modles
{
    internal class Appointment
    {
        public int Id { get; set; }
        public DateTime AppoDate { get; set; }
        public string Status { get; set; }
        public string Purpose { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
