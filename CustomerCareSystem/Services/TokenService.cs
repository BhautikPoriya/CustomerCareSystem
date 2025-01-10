using CustomerCareSystem.Models.Domain;
using CustomerCareSystem.Services.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace CustomerCareSystem.Services
{
    /// <summary>
    /// Represent token service
    /// </summary>
    public class TokenService : ITokenService
    {

        #region Fields

        private readonly CustomerCareSystemDbContext _customerCareSystemDbContext;

        #endregion

        #region Ctor

        public TokenService(CustomerCareSystemDbContext customerCareSystemDbContext)
        {
            _customerCareSystemDbContext = customerCareSystemDbContext;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inster a token
        /// </summary>
        /// <param name="token">token</param>
        /// <returns></returns>
        public async Task InsertTokenAsync(Token token)
        {
            await _customerCareSystemDbContext.Token.AddAsync(token);
            await SaveChangesAsync();
        }

        /// <summary>
        /// Get all tokens
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IList<Token>> GetAllTokenAsync()
        {
            return await _customerCareSystemDbContext.Token.ToListAsync();
        }

        /// <summary>
        /// Save changes 
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await _customerCareSystemDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
