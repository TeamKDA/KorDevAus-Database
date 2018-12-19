using System.Collections.Generic;
using System.Threading.Tasks;

using KorDevAus.Entities;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This provides interfaces to the <see cref="UserRepository"/> class.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Gets the list of the <see cref="User"/> instances.
        /// </summary>
        /// <param name="emails">List of email addresses.</param>
        /// <returns>Returns the list of the <see cref="User"/> instances.</returns>
        Task<List<User>> GetByEmailsAsync(IEnumerable<string> emails);

        /// <summary>
        /// Gets the <see cref="User"/> instance with the given email.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <returns>Returns the <see cref="User"/> instance with the given email.</returns>
        Task<User> GetByEmailAsync(string email);
    }
}