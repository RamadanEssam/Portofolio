namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        // generic  غير مرتبط بنوع معين 
        // هيكون فقط جيت لاننا سنرجعه
        IGenericRepository<T> Entity { get; }
        void Save();
    }
}
