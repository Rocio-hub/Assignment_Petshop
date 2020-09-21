using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PetshopRestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }


        //POST pets - CREATE
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            try
            {
                return StatusCode(201, _petService.CreatePet(pet));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }



        //GET api/pets - READ
        [HttpGet]
        public ActionResult<Pet> Get()
        {
            return Ok(_petService.ReadAllPets());
        }

        //GET api/pets/1 - READ BY ID
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            try
            {
                return Ok(_petService.FindPetbyID(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }



        //PUT pets/1 - UPDATE
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Pet pet)
        {
            try
            {
                return StatusCode(202, _petService.UpdatePetByID(id, pet));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }



        //DELETE api/pets/1 - DELETE
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            try
            {
                return StatusCode(202, _petService.DeleteByID(id));
            }
            catch (Exception e)
            {
                return StatusCode(505, e.Message);
            }
        }

    }
}
