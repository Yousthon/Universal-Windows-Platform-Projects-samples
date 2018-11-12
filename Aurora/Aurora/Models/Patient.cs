namespace Aurora.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return $"{this.Nom} {this.Prenom}";
        }
    }
}
