using API.Repositories.Interfaces;

namespace API.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IProductCategoryRepository ProductCategories { get; }
        void Save();
    }
}
