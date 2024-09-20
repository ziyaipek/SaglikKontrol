using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;


namespace Business.Services
{
    public class MedicationPatientService : BaseService<MedicationPatient, int, MedicationPatientResponseDTO>, IMedicationPatientService
    {
        public MedicationPatientService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.MedicationPatients, mapperHelper)
        {
        }
    }
}

