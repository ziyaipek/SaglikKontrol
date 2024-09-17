using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;


namespace Business.Services
{
    public class MedicationService : BaseService<Medication, int, MedicationResponseDTO>, IMedicationService
    {
        public MedicationService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.MedicationRepository, mapperHelper)
        {
        }
    }
}

