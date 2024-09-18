using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Business.Services;
using Business.Services.Interface;
namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAdminService, AdminService>();
        serviceCollection.AddScoped<IDiseaseService, DiseaseService>();
        serviceCollection.AddScoped<IDoctorPatientService, DoctorPatientService>();
        serviceCollection.AddScoped<IDoctorService, DoctorService>();
        serviceCollection.AddScoped<IMedicationPatientService, MedicationPatientService>();
        serviceCollection.AddScoped<IMedicationService, MedicationService>();
        serviceCollection.AddScoped<IPatientDiseaseService, PatientDiseaseService>();
        serviceCollection.AddScoped<IPatientService, PatientService>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
    }
    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }
}