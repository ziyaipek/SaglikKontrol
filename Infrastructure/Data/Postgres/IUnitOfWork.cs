using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres
{
    public interface IUnitOfWork : IDisposable
    {

        IAdminRepository Admins { get; }
        IDiseaseRepository Diseases { get; }
        IDoctorPatientRepository DoctorPatients { get; }
        IDoctorRepository Doctors { get; }
        IMedicationPatientRepository MedicationPatients { get; }
        IMedicationRepository Medications { get; }
        IPatientDiseaseRepository PatientDiseases { get; }
        IPatientRepository Patients { get; }

        Task<int> CommitAsync();
    }
}

