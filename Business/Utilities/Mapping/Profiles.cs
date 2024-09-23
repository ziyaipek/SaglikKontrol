using AutoMapper;
using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Security;
using System.Text.RegularExpressions;
using File = Infrastructure.Data.Postgres.Entities.File;

namespace Business.Utilities.Mapping
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Admin, AdminResponseDTO>(); 
            CreateMap<AdminCreateDTO, Admin>();   
            CreateMap<AdminUpdateDTO, Admin>();   

            CreateMap<Disease, DiseaseResponseDTO>();
            CreateMap<DiseaseCreateDTO, Disease>();
            CreateMap<DiseaseUpdateDTO, Disease>();

            CreateMap<Doctor, DoctorResponseDTO>();
            CreateMap<DoctorCreateDTO, Doctor>();
            CreateMap<DoctorUpdateDTO, Doctor>();

            CreateMap<DoctorPatient, DoctorPatientResponseDTO>();
            CreateMap<DoctorPatientCreateDTO, DoctorPatient>();
            CreateMap<DoctorPatientUpdateDTO, DoctorPatient>();

            CreateMap<Medication, MedicationResponseDTO>();
            CreateMap<MedicationCreateDTO, Medication>();
            CreateMap<MedicationUpdateDTO, Medication>();

            CreateMap<MedicationPatient, MedicationPatientResponseDTO>();
            CreateMap<MedicationPatientCreateDTO, MedicationPatient>();
            CreateMap<MedicationPatientUpdateDTO, MedicationPatient>();

            CreateMap<Patient, PatientResponseDTO>();
            CreateMap<PatientCreateDTO, Patient>();
            CreateMap<PatientUpdateDTO, Patient>();

            CreateMap<PatientDisease, PatientDiseaseResponseDTO>();
            CreateMap<PatientDiseaseCreateDTO, PatientDisease>();
            CreateMap<PatientDiseaseUpdateDTO, PatientDisease>();
        }
    }
}