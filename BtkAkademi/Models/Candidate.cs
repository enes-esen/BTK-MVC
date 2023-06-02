namespace BtkAkademi.Models
{
    public class Candidate
    {
        public String? Email { get; set; } = String.Empty;
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        //Kayıt anını kaydetmek için bir constructer kullarak o aki tarih değerini veririz.
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}