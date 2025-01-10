using CustomerCareSystem.Models.Domain;

namespace CustomerCareSystem.Services
{
    /// <summary>
    /// Represent token interface
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// Inster a token
        /// </summary>
        /// <param name="token">token</param>
        /// <returns></returns>
        Task InsertTokenAsync(Token token);

        /// <summary>
        /// Get all tokens
        /// </summary>
        /// <returns></returns>
        Task<IList<Token>> GetAllTokenAsync();
    }
}
