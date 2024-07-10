using System.ComponentModel.DataAnnotations;

namespace Tenaka_API.Model
{
    public static class Common
    {
        public enum ResponseCodes
        {
            [Display(Name = "SingalSessionSuccessful")]
            SingalSessionSuccessful = 1210,
            [Display(Name = "Successful")]
            Successful = 1200,
            [Display(Name = "Force Password Change")]
            ForcePasswordChange = 1201,
            [Display(Name = "Authentication Failed")]
            AuthenticationFailed = 1202,
            [Display(Name = "Account Locked")]
            AccountLocked = 1203,
            [Display(Name = "Invalid Tenant")]
            InvalidTenant = 1204,
            [Display(Name = "System Error")]
            SystemError = 1205,
        }
    }
}
