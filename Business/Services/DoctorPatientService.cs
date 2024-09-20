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
    public class DoctorPatientService : BaseService<DoctorPatient, int, DoctorPatientResponseDTO>, IDoctorPatientService
    {
        public DoctorPatientService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DoctorPatients, mapperHelper)
        {
        }
    }
}

