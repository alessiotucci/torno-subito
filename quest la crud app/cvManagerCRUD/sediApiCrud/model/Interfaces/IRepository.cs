namespace sediApiCrud.model.Interfaces
{
    public interface IRepository
    {
        //those are the methods to be called by the IRepository
        public List<Sede> GetAll();
        // we could use an other interface called IQueryable since we are working with 
        // in this case we decided to work with the list<T>
        public Sede GetById(int id);
        // those are the methods for the CRUD applications
        public Sede Update(Sede sede);
        public Sede DeleteById(int id);
        public Sede Create(Sede sede);

    }
}
