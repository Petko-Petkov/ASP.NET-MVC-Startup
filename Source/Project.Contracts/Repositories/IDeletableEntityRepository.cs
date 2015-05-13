namespace Project.Contracts.Repositories
{
    using System.Linq;
    using BlogSystem.Data.Contracts;

    public interface IDeletableEntityRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> AllWithDeleted();
    }
}
