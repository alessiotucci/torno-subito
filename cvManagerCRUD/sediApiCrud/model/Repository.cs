using sediApiCrud.model.Interfaces;

namespace sediApiCrud.model
{
    // this class is called Repository, and we use it to implemetn the IRepository interface
    // to generalize all this stuff we use the <T>
    public class Repository : IRepository
    {
        // I have created  a private context var of type ApplicationDbContext
        private ApplicationDbContext context;
        
        // this is the constructor of Repository
        public Repository(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public Sede Create(Sede sede)
        {
           var result =  context.Sedi.Add(sede).Entity;
            context.SaveChanges();
            return result;
        }

        public Sede DeleteById(int id)
        {
           var result = context.Sedi.Remove(GetById(id)).Entity;
            context.SaveChanges();
            return result;
        }

        public List<Sede> GetAll()
        {
            return context.Sedi.ToList();
        }

        public Sede GetById(int id)
        {
            return context.Sedi.Where(s => s.Id == id).SingleOrDefault();

        }

        public Sede Update(Sede sede)
        {
            var result = context.Sedi.Update(sede).Entity;
            context.SaveChanges();
            return result;
        }
    }
}
