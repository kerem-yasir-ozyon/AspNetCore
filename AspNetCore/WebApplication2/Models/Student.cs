using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "Soyadı")]
        public string Surname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi")]
        public DateOnly BirthDate { get; set; }

        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }

        [Display(Name = "Favori Araba")]
        public Cars FavoriteCar { get; set; }

    }

    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male,

        [Display(Name = "Kadın")]
        Female
    }

    public enum Cars
    {
        Audi,
        Bmw,
        Tofas
    }
}
