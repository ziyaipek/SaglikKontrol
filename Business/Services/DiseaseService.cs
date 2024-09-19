using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
<<<<<<< HEAD

=======
>>>>>>> origin/batuhan


namespace Business.Services
{
    public class DiseaseService : BaseService<Disease, int, DiseaseResponseDTO>, IDiseaseService
    {
        public DiseaseService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DiseaseRepository, mapperHelper)
        {
        }
    }
}

