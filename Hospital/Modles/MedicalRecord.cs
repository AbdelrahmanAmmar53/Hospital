using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Modles
{
    internal class MedicalRecord
    {
        public int Id { get; set; }
        public DateTime DateCreat { get; set; }
        public string Diagnosis {  get; set; }
        public string Note { get; set; }
        public string prescribedTreatment { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public ICollection<Treatment> Treatments { get; set; }

    }
}
