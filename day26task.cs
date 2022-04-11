using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    class day26task
    {
        public static void Main()
        {
            IList<Doctor> Docdata = new List<Doctor>()
            {
                new Doctor(){DoctorID=1,DoctorName="Dr.Vijay",DoctorAge=47,SpecialistID=1},
                new Doctor(){DoctorID=2,DoctorName="Dr.Kavitha",DoctorAge=53,SpecialistID=2},
                new Doctor(){DoctorID=3,DoctorName="Dr.Vinod prem",DoctorAge=35,SpecialistID=3},
                new Doctor(){DoctorID=4,DoctorName="Dr.T V Ashokan",DoctorAge=30,SpecialistID=1},
                new Doctor(){DoctorID=5,DoctorName="Dr.Santhosh",DoctorAge=42,SpecialistID=2},
                new Doctor(){DoctorID=6,DoctorName="Dr.Aravindh",DoctorAge=40,SpecialistID=3},

            };
            IList<Specialist> SpecData = new List<Specialist>()
            {
                new Specialist(){SpecialistID=1, SpecialistOf="pediatrics"},
                new Specialist(){SpecialistID=2, SpecialistOf="psychiatrist"},
                new Specialist(){SpecialistID=3, SpecialistOf="neurology"}
            };
            var JoinData = Docdata.Join(
                SpecData,
                doc=> doc.SpecialistID,
                spec => spec.SpecialistID,
                (doc, spec) => new
                {
                    DoctorName = doc.DoctorName,
                    Specialist = spec.SpecialistOf
                }
                );
            foreach (var v in JoinData)
            {
                Console.WriteLine(v.DoctorName  + " " + v.Specialist);
            }
        }
    }
    public class Specialist
    {
        public int SpecialistID { get; set; }
        public string SpecialistOf { get; set; }
    }
     class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int DoctorAge { get; set; }
        public int SpecialistID { get; set; }

    }
  

}

