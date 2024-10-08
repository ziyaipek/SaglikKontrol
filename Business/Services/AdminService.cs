﻿using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using System.Data;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;

namespace Business.Services
{
    public class AdminService : BaseService<Admin, int, AdminResponseDTO>, IAdminService
    {
        public AdminService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.AdminRepository, mapperHelper)
        {
        }
    }
}

