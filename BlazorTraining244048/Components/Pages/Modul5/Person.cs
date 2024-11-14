using System.ComponentModel.DataAnnotations;

namespace BlazorTraining244048.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,MinimumLength =3, ErrorMessage ="zwischen 3 und 10 Zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(100,190, ErrorMessage ="zwischen 100 und 190, sonst tot")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }
    }
}
