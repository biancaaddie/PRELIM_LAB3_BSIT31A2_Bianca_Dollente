namespace PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Models
{
    public abstract class BaseEntity : IDescribable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age)) age--;
            return age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

        public virtual string Describe()
        {
            return $"Entity: {GetFullName()} {GetAge()}";
        }
    }
}