namespace Repositories.Interfaces
{
    public interface IRepositoryManager
    {
        IPostRepository Post { get; }
        void Save();
    }
}
