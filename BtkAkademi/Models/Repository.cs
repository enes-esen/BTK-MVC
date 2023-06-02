namespace BtkAkademi.Models
{
    public class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;

        //formdan gelecek verileri ekleyecek bir kod bloğu yazımı
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}