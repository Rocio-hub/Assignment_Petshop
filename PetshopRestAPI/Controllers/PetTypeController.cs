using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using CompulsoryPetshop.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace PetshopRestAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeService _petTypeService;

        public PetTypeController(IPetTypeService petTypeService)
        {
            _petTypeService = petTypeService;
        }

        //GET api/petType - READ
        [HttpGet]
        public ActionResult<List<PetType>> Get()
        {
            return _petTypeService.ReadAllPetTypes();
        }

        //GET api/petType/ - READ BY ID
        [HttpGet("{id}")]
        public ActionResult<PetType> Get(int id)
        {
            try
            {
                return Ok(_petTypeService.ReadPetTypeByID(id));
            }
            catch (Exception e)
            {
                return StatusCode(505, e.Message);
            }
        }

        //POST api/petType - CREATE
        [HttpPost]
        public ActionResult<PetType> Post([FromBody] PetType petType)
        {
            try
            {
                return StatusCode(201,_petTypeService.CreatePetType(petType));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        //PUT pets/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, [FromBody] PetType petType)
        {
            try
            {
                return StatusCode(202, _petTypeService.UploadPetTypeByID(id, petType));
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
                return StatusCode(202,_petTypeService.DeleteByID(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
