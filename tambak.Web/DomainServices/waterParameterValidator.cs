using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace tambak.Web.DomainServices
{
    public class waterParameterValidator
    {

        public static ValidationResult validateAmmonia(ValidationContext context)
        {
            Regex objReg=new Regex(@"^[-+]?[0-9]\d*\.?[0-9]*$");
            WaterParameterLog WaterParamLog = context.ObjectInstance as WaterParameterLog;

            Match objMatch = objReg.Match(WaterParamLog.Amonnia.ToString());

            if (WaterParamLog.Amonnia == null || objMatch.Success)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(@"Amonia has to be number or null");
            }
        }
    }
}