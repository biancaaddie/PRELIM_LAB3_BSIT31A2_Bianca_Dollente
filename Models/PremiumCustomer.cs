namespace PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Models
{
    public class PremiumCustomer : Customer
    {
            public bool IsVip { get; set; } = true;

            public override string Describe()
            {
                return $"VIP Customer, {GetFullName()} {GetAge()} {CustomerId}";
            }
        }
    }
