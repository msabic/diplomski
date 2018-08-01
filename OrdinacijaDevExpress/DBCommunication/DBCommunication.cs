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
        List<Doctor> GetDoctorID(int doctorID);
        bool InsertDoctor(Doctor dr);
        bool UpdateDoctor(Doctor dr);
        bool ChangePassword(int id, string password);
        bool DeleteDoctor(Doctor dr);
        List<Patient> GetPatient();
        List<Patient> GetPatientID(int patientID);
        bool InsertPatient(Patient patient);
        bool UpdatePatient(Patient patient);
        bool DeletePatient(Patient patient);
        List<NonWorkingDays> GetNonWorkingDays();
        bool GetNonWorkingDay(string date);
        bool InsertNonWorkingDays(NonWorkingDays nonWorkingDays);
        bool UpdateNonWokringDays(NonWorkingDays nonWorkingDays);
        bool DeleteNonWorkingDays(NonWorkingDays nonWorkingDays);
        List<VisitDoctor> GetVisitDoctor();
        List<VisitDoctor> GetVistiDoctorForPatient(int patientID);
        bool InsertVisitDoctor(VisitDoctor visitDoctor);
        bool UpdateVisitDoctor(VisitDoctor visitDoctor);
        bool DeleteVisitDoctor(VisitDoctor visitDoctor);
        List<Prescription> GetPrescription();
        bool InsertPrescription(Prescription prescription);
        bool UpdatePrescription(Prescription prescription);
        bool DeletePrescription(Prescription prescription);
        List<Referral> GetReferral();
        List<Referral> GetReferralForPatient(int patientID);
        bool InsertReferral(Referral referral);
        bool UpdateReferral(Referral referral);
        bool DeleteReferral(Referral referral);

        List<PatientInfo> GetPatientInfo();
        List<PatientInfo> GetPatientInfoID(int patientID);
        bool InsertPatientInfo(PatientInfo patientInfo);
        bool UpdatePatientInfo(PatientInfo patientInfo);
        bool DeletePatientInfo(PatientInfo patientInfo);

        List<Diagnosis> GetDiagnosis();
        List<Diagnosis> GetDiagnosisForPatient(int patient);
        bool InsertDiagnosis(Diagnosis diagnosis);
        bool UpdateDiagnosis(Diagnosis diagnosis);
        bool DeleteDiagnosis(Diagnosis diagnosis);

        List<AgreedTerm> GetAgreedTerm();
        List<AgreedTerm> GetAgreedTermForPatient(int patient);
        List<AgreedTerm> AgreedTemForDoctor(int doctor);
        bool InsertAgreedTerm(AgreedTerm agreedTerm);
        bool UpdateAgreedTerm(AgreedTerm agreedTerm);
        bool DeleteAgreedTerm(AgreedTerm agreedTerm);

        List<Patient> GetPatientForDoctor(int doctorID);

        string Login(string email, string password);
    }
}
