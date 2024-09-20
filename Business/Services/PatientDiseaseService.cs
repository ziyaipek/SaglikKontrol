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
    public class PatientDiseaseService : BaseService<PatientDisease, int, PatientDiseaseResponseDTO>, IPatientDiseaseService
    {
        public PatientDiseaseService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.PatientDiseases, mapperHelper)
        {
        }
    }
}

