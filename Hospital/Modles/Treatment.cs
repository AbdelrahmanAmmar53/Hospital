using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Modles
{
    internal class Treatment
    {
        public int Id { get; set; }
        public DateTime TreatDate { get; set; }
        public string OutCome { get; set; }
        public string TypesOfTreatment { get; set; }
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
