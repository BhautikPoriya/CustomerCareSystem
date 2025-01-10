using CustomerCareSystem.Models;
using CustomerCareSystem.Models.Domain;
using CustomerCareSystem.Services.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace CustomerCareSystem.Services
{
    /// <summary>
    /// Executive service
    /// </summary>
    public class ExecutiveService : IExecutiveService
    {

        #region Fields

        private readonly CustomerCareSystemDbContext _customerCareSystemDbContext;

        #endregion


        #region Ctor

        public ExecutiveService(CustomerCareSystemDbContext customerCareSystemDbContext)
        {
            _customerCareSystemDbContext = customerCareSystemDbContext; 
        }

        #endregion

        #region Methods

        public async Task<ExecutiveLogin> ValidateExecutive(LoginModel loginModel)
        {
            return await _customerCareSystemDbContext.ExecutiveLogin
                .Where(x => x.User.Equals(loginModel.Email) && 
                        x.Password.Equals(loginModel.Password)).FirstOrDefaultAsync();
        }

        #endregion
    }
}
