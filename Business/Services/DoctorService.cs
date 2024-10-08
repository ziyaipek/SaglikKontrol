﻿using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;


namespace Business.Services
{
    public class DoctorService : BaseService<Doctor, int, DoctorResponseDTO>, IDoctorService
    {
        public DoctorService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DoctorRepository, mapperHelper)
        {
        }
    }
}

