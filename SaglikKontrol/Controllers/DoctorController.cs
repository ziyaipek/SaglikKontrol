using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DoctorController : BaseCRUDController<Doctor, int, DoctorCreateDTO, DoctorUpdateDTO, DoctorResponseDTO>
    {
        public DoctorController(IDoctorService service) : base(service)
        {
        }
    }
}
