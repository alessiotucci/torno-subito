using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sediApiCrud.model;
using sediApiCrud.model.Interfaces;

namespace sediApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sediCrudController : ControllerBase
    {
        // this will be out controller;
        // this is a standard template with  the route (" api/[controller]") and extend the class with controller base

        //lets not forget about constructor
        private IRepository repository;
        public sediCrudController(IRepository repository)
        {
            this.repository = repository;
        }


        // we will create 5 methods similar to what we have done previously;
        [HttpGet]
        public List<Sede> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id:int}")]
        public Sede GetById(int id)
        {
            return repository.GetById(id);
        }

        // for the create we need the https create
        [HttpPost]
        public Sede Post([FromBody] Sede sede)
        {
            return repository.Create(sede);
        }

        // for the update we need the https put
        [HttpPut]

        public Sede Put([FromBody] Sede sede)
        {
            return repository.Update(sede);
        }
        // now for the delete 
        [HttpDelete("{id:int}")]
        public Sede DeleteById(int id)
        {
            return repository.DeleteById(id);
        }
    }

}
