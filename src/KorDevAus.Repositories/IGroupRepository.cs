using System.Threading.Tasks;

using KorDevAus.Entities;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This provides interfaces to the <see cref="GroupRepository"/> class.
    /// </summary>
    public interface IGroupRepository : IRepository<Group>
    {
        /// <summary>
        /// Gets the <see cref="Group"/> instance with the given group name.
        /// </summary>
        /// <param name="name">Group name.</param>
        /// <returns>Returns the <see cref="Group"/> instance with the given group name.</returns>
        Task<Group> GetByNameAsync(string name);
    }
}