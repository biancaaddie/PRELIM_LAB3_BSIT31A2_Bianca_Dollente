namespace PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Models
{
    public class PremiumCustomer : Customer
    {
            public string MembershipLevel { get; set; }

            public override string Describe()
            {
                return $"Premium Customer: {Name}, Email: {Email}, Level: {MembershipLevel}";
            }
        }
}
