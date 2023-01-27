using System.ComponentModel.DataAnnotations;

namespace OperaWebSitee.Validations
{
    public class CheckValidYearAttribute : ValidationAttribute
    {
        public CheckValidYearAttribute() 
        {
            ErrorMessage = "El año debe ser Mayor o igual a 1598";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1598)
            {
                return false;

            }
            else
            {
                return true;
            }

        }
    }
}
