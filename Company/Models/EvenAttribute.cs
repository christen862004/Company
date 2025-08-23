using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class EvenAttribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int valFromRequest = int.Parse(value.ToString());
            if (valFromRequest % 2 == 0)
                return true;
            return false;
        }
    }
}
