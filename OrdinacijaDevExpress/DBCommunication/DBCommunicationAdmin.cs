using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication 
{
    public class DBCommunicationAdmin : DBCommunication
    {
        public List<Working_time> GetWorkingTime()
        {
            try
            {
                GetWorkingTime getWorkingTime = new GetWorkingTime();
                return getWorkingTime.Execute();
            }
            catch 
            {
                return null;
            }
            finally
            {

            }
        }
        public List<Doctor> GetDoctor()
        {
            try
            {
                GetDoctor getDoctor = new GetDoctor();
                return getDoctor.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Doctor> GetDoctorID(int doctorID)
        {
            try
            {
                GetDoctorID getDoctor = new GetDoctorID();
                return getDoctor.Execute(doctorID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertDoctor(Doctor dr)
        {
            try
            {
                InsertDoctor insertDoctor = new InsertDoctor();
                insertDoctor.Execute(dr);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                
            }
        }
        public bool UpdateDoctor(Doctor dr)
        {
            try
            {
                UpdateDoctor updateDoctor = new UpdateDoctor();
                updateDoctor.Execute(dr);
                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {

            }
        }
        public bool ChangePassword(int id, string password)
        {
            try
            {
                ChangePassword changePassword = new ChangePassword();
                changePassword.Execute(id, password);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public bool DeleteDoctor(Doctor dr)
        {
            try
            {
                DeleteDoctor deleteDoctor = new DeleteDoctor();
                deleteDoctor.Execute(dr);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Patient> GetPatient()
        {
            try
            {
                GetPatient getPatient = new GetPatient();
                return getPatient.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Patient> GetPatientID(int patientID)
        {
            try
            {
                GetPatientID getPatient = new GetPatientID();
                return getPatient.Execute(patientID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertPatient(Patient patient)
        {
            try
            {
                InsertPatient insertPatient = new InsertPatient();
                insertPatient.Execute(patient);
                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {

            }
        }
        public bool UpdatePatient(Patient patient)
        {
            try
            {
                UpdatePatient updatePatient = new UpdatePatient();
                updatePatient.Execute(patient);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeletePatient(Patient patient)
        {
            try
            {
                DeletePatient deletePatient = new DeletePatient();
                deletePatient.Execute(patient);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertWorkingDay(Working_time workingTime)
        {
            try
            {
                InsertWorkingDay insertWorkingDay = new InsertWorkingDay();
                insertWorkingDay.Execute(workingTime);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool UpdateWorkingDays(Working_time workingTime)
        {
            try
            {
                UpdateWorkingDays updateWorkingDays = new UpdateWorkingDays();
                updateWorkingDays.Execute(workingTime);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeleteWorkingDay(Working_time workingTime)
        {
            try
            {
                DeleteWorkingDay deleteWorkingDay = new DeleteWorkingDay();
                deleteWorkingDay.Execute(workingTime);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<NonWorkingDays> GetNonWorkingDays()
        {
            try
            {
                GetNonWorkingDays getNonWorkingDays = new GetNonWorkingDays();
                return getNonWorkingDays.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool GetNonWorkingDay(string date)
        {
            try
            {
                GetNonWorkingDay getNonWorkingDay = new GetNonWorkingDay();
                return getNonWorkingDay.Execute(date);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {

            }
        }

        public bool InsertNonWorkingDays(NonWorkingDays nonWorkingDays)
        {
            try
            {
                InsertNonWorkingDays insertNonWorkingDays = new InsertNonWorkingDays();
                insertNonWorkingDays.Execute(nonWorkingDays);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool UpdateNonWokringDays(NonWorkingDays nonWorkingDays)
        {
            try
            {
                UpdateNonWorkingDays updateNonWorkingDays = new UpdateNonWorkingDays();
                updateNonWorkingDays.Execute(nonWorkingDays);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeleteNonWorkingDays(NonWorkingDays nonWorkingDays)
        {
            try
            {
                DeleteNonWorkingDays deleteNonWorkingDays = new DeleteNonWorkingDays();
                deleteNonWorkingDays.Execute(nonWorkingDays);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<VisitDoctor> GetVisitDoctor()
        {
            try
            {
                GetVisitDoctor getVisitDoctor = new GetVisitDoctor();
                return getVisitDoctor.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<VisitDoctor> GetVistiDoctorForPatient(int patientID)
        {
            try
            {
                GetVistiDoctorForPatient getVisitDoctorForPatient = new GetVistiDoctorForPatient();
                return getVisitDoctorForPatient.Execute(patientID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertVisitDoctor(VisitDoctor visitDoctor)
        {
            try
            {
                InsertVisitDoctor insertVisitDoctor = new InsertVisitDoctor();
                insertVisitDoctor.Execute(visitDoctor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool UpdateVisitDoctor(VisitDoctor visitDoctor)
        {
            try
            {
                UpdateVisitDoctor updateVisitDoctor = new UpdateVisitDoctor();
                updateVisitDoctor.Execute(visitDoctor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeleteVisitDoctor(VisitDoctor visitDoctor)
        {
            try
            {
                DeleteVisitDoctor deleteVisitDoctor = new DeleteVisitDoctor();
                deleteVisitDoctor.Execute(visitDoctor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Prescription> GetPrescription()
        {
            try
            {
                GetPrescription getPrescription = new GetPrescription();
                return getPrescription.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }

        public bool InsertPrescription(Prescription prescription)
        {
            try
            {
                InsertPrescription insertPrescription = new InsertPrescription();
                insertPrescription.Execute(prescription);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool UpdatePrescription(Prescription prescription)
        {
            try
            {
                UpdatePrescription updatePrescription = new UpdatePrescription();
                updatePrescription.Execute(prescription);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeletePrescription(Prescription prescription)
        {
            try
            {
                DeletePrescription deletePrescription = new DeletePrescription();
                deletePrescription.Execute(prescription);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }

        public List<Referral> GetReferral()
        {
            try
            {
                GetReferral getReferral = new GetReferral();
                return getReferral.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Referral> GetReferralForPatient(int patientID)
        {
            try
            {
                GetReferralForPatient getReferral = new GetReferralForPatient();
                return getReferral.Execute(patientID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertReferral(Referral referral)
        {
            try
            {
                InsertReferral insertReferral = new InsertReferral();
                insertReferral.Execute(referral);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool UpdateReferral(Referral referral)
        {
            try
            {
                UpdateReferral updateReferral = new UpdateReferral();
                updateReferral.Execute(referral);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeleteReferral(Referral referral)
        {
            try
            {
                DeleteReferral deleteReferral = new DeleteReferral();
                deleteReferral.Execute(referral);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<PatientInfo> GetPatientInfo()
        {
            try
            {
                GetPatientInfo getPatientInfo = new GetPatientInfo();
                return getPatientInfo.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<PatientInfo> GetPatientInfoID(int patientID)
        {
            try
            {
                GetPatientInfoID getPatientInfoID = new GetPatientInfoID();
                return getPatientInfoID.Execute(patientID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertPatientInfo(PatientInfo patientInfo)
        {
            try
            {
                InsertPatientInfo insertPatientInfo = new InsertPatientInfo();
                insertPatientInfo.Execute(patientInfo);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public bool UpdatePatientInfo(PatientInfo patientInfo)
        {
            try
            {
                UpdatePatientInfo updatePatientInfo = new UpdatePatientInfo();
                updatePatientInfo.Execute(patientInfo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeletePatientInfo(PatientInfo patientInfo)
        {
            try
            {
                DeletePatientInfo deletePatientInfo = new DeletePatientInfo();
                deletePatientInfo.Execute(patientInfo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Diagnosis> GetDiagnosis()
        {
            try
            {
                GetDiagnosis getDiagnosis = new GetDiagnosis();
                return getDiagnosis.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<Diagnosis> GetDiagnosisForPatient(int patient)
        {
            try
            {
                GetDiagnosisForPatient getDiagnosis = new GetDiagnosisForPatient();
                return getDiagnosis.Execute(patient);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertDiagnosis(Diagnosis diagnosis)
        {
            try
            {
                InsertDiagnosis inserDiagnosis = new InsertDiagnosis();
                inserDiagnosis.Execute(diagnosis);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public bool UpdateDiagnosis(Diagnosis diagnosis)
        {
            try
            {
                UpdateDiagnosis updateDiagnosis = new UpdateDiagnosis();
                updateDiagnosis.Execute(diagnosis);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }
        public bool DeleteDiagnosis(Diagnosis diagnosis)
        {
            try
            {
                DeleteDiagnosis deleteDiagnosis = new DeleteDiagnosis();
                deleteDiagnosis.Execute(diagnosis);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

            }
        }

        public List<AgreedTerm> GetAgreedTerm()
        {
            try
            {
                GetAgreedTerm getAgreedTerm = new GetAgreedTerm();
                return getAgreedTerm.Execute();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<AgreedTerm> GetAgreedTermForPatient(int patient)
        {
            try
            {
                GetAgreedTermForPatient getAgreedTerm = new GetAgreedTermForPatient();
                return getAgreedTerm.Execute(patient);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public List<AgreedTerm> AgreedTemForDoctor(int doctor)
        {
            try
            {
                AgreedTemForDoctor getAgreedTerm = new AgreedTemForDoctor();
                return getAgreedTerm.Execute(doctor);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public bool InsertAgreedTerm(AgreedTerm agreedTerm)
        {
            try
            {
                InsertAgreedTerm insertAgreedTerm = new InsertAgreedTerm();
                insertAgreedTerm.Execute(agreedTerm);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public bool UpdateAgreedTerm(AgreedTerm agreedTerm)
        {
            try
            {
                UpdateAgreedTerm updateAgreedTerm = new UpdateAgreedTerm();
                updateAgreedTerm.Execute(agreedTerm);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public bool DeleteAgreedTerm(AgreedTerm agreedTerm)
        {
            try
            {
                DeleteAgreedTerm deleteAgreedTerm = new DeleteAgreedTerm();
                deleteAgreedTerm.Execute(agreedTerm);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }
        public List<Patient> GetPatientForDoctor(int doctorID)
        {
            try
            {
                GetPatientForDoctor getPatientForDoctor = new GetPatientForDoctor();
                return getPatientForDoctor.Execute(doctorID);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {

            }
        }
        public string Login(string email, string password)
        {
            try
            {
                Login login = new Login();
                return login.Execute( email, password);
                
            }
            catch
            {
                return string.Empty;
            }
            finally
            {

            }
        }
    }
}
