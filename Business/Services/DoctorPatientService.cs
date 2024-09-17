using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;


namespace Business.Services
{
    public class DoctorPatientService : BaseService<DoctorPatient, int, DoctorPatientResponseDTO>, IDoctorPatientService
    {
        public DoctorPatientService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DoctorPatientRepository, mapperHelper)
        {
        }
    }
}

