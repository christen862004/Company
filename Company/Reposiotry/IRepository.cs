namespace Company.Reposiotry
{
    //Open Type :Generic
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        
        void Add(T obj);
        void Edit(T obj);
        void Delete(int id);
        
        void Save();
    }
}
