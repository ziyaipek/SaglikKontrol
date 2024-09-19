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
using Business.Utilities.Mapping.Interface;



namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<AdminCreateDTO, Admin>();
        CreateMap<DiseaseCreateDTO, Disease>();
        CreateMap<DoctorCreateDTO, Doctor>();
        CreateMap<DoctorPatientCreateDTO, DoctorPatient>();
        CreateMap<MedicationCreateDTO, Medication>();
        CreateMap<MedicationPatientCreateDTO, MedicationPatient>();
        CreateMap<PatientCreateDTO, Patient>();
        CreateMap<PatientDiseaseCreateDTO, PatientDisease>();

        CreateMap<AdminUpdateDTO, Admin>();
        CreateMap<DiseaseUpdateDTO, Disease>();
        CreateMap<DoctorUpdateDTO, Doctor>();
        CreateMap<DoctorPatientUpdateDTO, DoctorPatient>();
        CreateMap<MedicationUpdateDTO, Medication>();
        CreateMap<MedicationPatientUpdateDTO, MedicationPatient>();
        CreateMap<PatientUpdateDTO, Patient>();
        CreateMap<PatientDiseaseUpdateDTO, PatientDisease>();

        CreateMap<AdminResponseDTO, Admin>();
        CreateMap<DiseaseResponseDTO, Disease>();
        CreateMap<DoctorResponseDTO, Doctor>();
        CreateMap<DoctorPatientResponseDTO, DoctorPatient>();
        CreateMap<MedicationResponseDTO, Medication>();
        CreateMap<MedicationPatientResponseDTO, MedicationPatient>();
        CreateMap<PatientResponseDTO, Patient>();
        CreateMap<PatientDiseaseResponseDTO, PatientDisease>();
    }
}