using DotnetApiBoilerplatev1._0.Model.Entities;

namespace DotnetApiBoilerplatev1._0.Model.DTO.Out
{
    public class LoginResponseDTO
    {
        public string Email { get; set; }
        public List<Roles> Roles { get; set; }
        public bool IsActive { get; set; }
    }
}
