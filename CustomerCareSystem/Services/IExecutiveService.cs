using CustomerCareSystem.Models;
using CustomerCareSystem.Models.Domain;

namespace CustomerCareSystem.Services
{
    /// <summary>
    /// Represent Executive interface
    /// </summary>
    public interface IExecutiveService
    {

        /// <summary>
        /// Validate executive
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        Task<ExecutiveLogin> ValidateExecutive(LoginModel loginModel);
    }
}
