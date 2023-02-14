using API.Models;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : Controller
    {
        private readonly IService<ChildDTO> _child;

        public ChildController(IService<ChildDTO> child)
        {
            _child = child;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _child.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _child.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel postModel)
        {
            ChildDTO newOne = new ChildDTO();
            newOne.tz = postModel.tz;
            newOne.BirthDate = postModel.BirthDate;
            newOne.FirstName = postModel.FirstName;
            newOne.LastName = postModel.LastName;
            newOne.Id = postModel.Id;
            //newOne.parent = postModel.Parent;
            newOne.ParentId = postModel.ParentId;
            return await _child.Add(newOne);
        }
    }
}

