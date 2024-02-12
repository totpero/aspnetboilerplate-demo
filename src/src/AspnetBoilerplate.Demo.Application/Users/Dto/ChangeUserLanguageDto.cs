using System.ComponentModel.DataAnnotations;

namespace AspnetBoilerplate.Demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}