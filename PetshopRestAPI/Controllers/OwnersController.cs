using CompulsoryPetshop.Core.ApplicationService.Service;
using CompulsoryPetshop.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace PetshopRestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnersController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }


        //POST -- Create
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            try
            {
                return StatusCode(201,_ownerService.CreateOwner(owner));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        //GET -- Read
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return Ok(_ownerService.GetAllOwners());
        }


        //PUT -- Update
        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner owner)
        {
            try
            {
                return Ok(_ownerService.UpdateOwner(id, owner));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }           
        }

        //DELETE -- Delete
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {

            try
            {
                return Ok(_ownerService.DeleteOwner(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
