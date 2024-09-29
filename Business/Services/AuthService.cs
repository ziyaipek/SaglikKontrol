using Business.Models.Request.Functional;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IConfiguration _config;

        public AuthService(IAdminRepository adminRepo, IDoctorRepository doctorRepo, IPatientRepository patientRepo, IConfiguration config)
        {
            _adminRepository = adminRepo;
            _doctorRepository = doctorRepo;
            _patientRepository = patientRepo;
            _config = config;
        }

        public LoginResponseDTO Authenticate(LoginRequestDTO request)
        {
            // Admin, Doctor ve Patient tablolarını kontrol et
            var admin = _adminRepository.GetByUsername(request.Username);
            var doctor = _doctorRepository.GetByUsername(request.Username);
            var patient = _patientRepository.GetByUsername(request.Username);

            // Her bir tablo için kontrol işlemi
            if (admin != null && VerifyPassword(admin.Password, request.Password))
            {
                return CreateLoginResponse(admin.Username, "Admin");
            }
            else if (doctor != null && VerifyPassword(doctor.DoctorPassword, request.Password))
            {
                return CreateLoginResponse(doctor.DoctorUsername, "Doctor");
            }
            else if (patient != null && VerifyPassword(patient.Password, request.Password))
            {
                return CreateLoginResponse(patient.Username, "Patient");
            }

            // Kullanıcı bulunamadıysa null döneriz
            return null;
        }

        private bool VerifyPassword(string storedPassword, string enteredPassword)
        {
            // Şifreyi doğrula (hash ile de yapılabilir)
            return storedPassword == enteredPassword;
        }

        private LoginResponseDTO CreateLoginResponse(string username, string role)
        {
            // Token oluştur
            var token = GenerateJwtToken(username, role);

            return new LoginResponseDTO
            {
                Token = token,
                Role = role,
                Expiration = DateTime.UtcNow.AddHours(1) // Token 1 saat geçerli olacak
            };
        }

        private string GenerateJwtToken(string username, string role)
        {
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(ClaimTypes.Role, role),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
            
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecretKey12345MySuperSecretKey12345"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
