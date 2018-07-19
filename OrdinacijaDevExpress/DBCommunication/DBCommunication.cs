using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public interface DBCommunication
    {
        List<Working_time> GetWorkingTime();
        bool InsertWorkingDay(Working_time workingtime);
        bool UpdateWorkingDays(Working_time woekingtime);
        bool DeleteWorkingDay(Working_time workingtime);
        List<Doctor> GetDoctor();
        bool InsertDoctor(Doctor dr);
        bool UpdateDoctor(Doctor dr);
        bool DeleteDoctor(Doctor dr);
        List<Patient> GetPatient();
        bool InsertPatient(Patient patient);
        bool UpdatePatient(Patient patient);
        bool DeletePatient(Patient patient);
        List<NonWorkingDays> GetNonWorkingDays();
        bool InsertNonWorkingDays(NonWorkingDays nonWorkingDays);
        bool UpdateNonWokringDays(NonWorkingDays nonWorkingDays);
        bool DeleteNonWorkingDays(NonWorkingDays nonWorkingDays);
        List<VisitDoctor> GetVisitDoctor();
        bool InsertVisitDoctor(VisitDoctor visitDoctor);
        bool UpdateVisitDoctor(VisitDoctor visitDoctor);
        bool DeleteVisitDoctor(VisitDoctor visitDoctor);
        List<Prescription> GetPrescription();
        bool InsertPrescription(Prescription prescription);
        bool UpdatePrescription(Prescription prescription);
        bool DeletePrescription(Prescription prescription);
        List<Referral> GetReferral();
        bool InsertReferral(Referral referral);
        bool UpdateReferral(Referral referral);
        bool DeleteReferral(Referral referral);

        List<PatientInfo> GetPatientInfo();
        bool InsertPatientInfo(PatientInfo patientInfo);
        bool UpdatePatientInfo(PatientInfo patientInfo);
        bool DeletePatientInfo(PatientInfo patientInfo);

        List<Diagnosis> GetDiagnosis();
        bool InsertDiagnosis(Diagnosis diagnosis);
        bool UpdateDiagnosis(Diagnosis diagnosis);
        bool DeleteDiagnosis(Diagnosis diagnosis);
    }
}
