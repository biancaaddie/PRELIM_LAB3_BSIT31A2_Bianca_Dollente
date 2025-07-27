namespace PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Models
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }

        public override string Describe()
        {
            return $"Regular Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}