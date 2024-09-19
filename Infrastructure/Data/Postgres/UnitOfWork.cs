using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;
    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    
    private AdminRepository? _adminRepository;
    private DiseaseRepository? _diseaseRepository;
    private DoctorPatientRepository? _doctorPatientRepository;
    private DoctorRepository? _doctorRepository;
    private MedicationPatientRepository? _medicationPatientRepository;
    private MedicationRepository? _medicationRepository;
    private PatientDiseaseRepository? _patientDiseaseRepository;
    private PatientRepository? _patientRepository;


    public IAdminRepository Admins => _adminRepository ??= new AdminRepository(_postgresContext);
    public IDiseaseRepository Diseases => _diseaseRepository ??= new DiseaseRepository(_postgresContext);
    public IDoctorPatientRepository DoctorPatients => _doctorPatientRepository ??= new DoctorPatientRepository(_postgresContext);
    public IDoctorRepository Doctors => _doctorRepository ??= new DoctorRepository(_postgresContext);
    public IMedicationPatientRepository MedicationPatients => _medicationPatientRepository ??= new MedicationPatientRepository(_postgresContext);
    public IMedicationRepository Medications => _medicationRepository ??= new MedicationRepository(_postgresContext);
    public IPatientDiseaseRepository PatientDiseases => _patientDiseaseRepository ??= new PatientDiseaseRepository(_postgresContext);
    public IPatientRepository Patients => _patientRepository ??= new PatientRepository(_postgresContext);



    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToLocalTime();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}
