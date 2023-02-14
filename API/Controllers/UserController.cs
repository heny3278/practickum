using API.Models;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _user;

        public UserController(IService<UserDTO> user)
        {
            _user = user;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();
            newOne.tz = postModel.tz;
            newOne.BirthDate = postModel.BirthDate; 
            newOne.FirstName = postModel.FirstName;
            newOne.LastName = postModel.LastName;
            newOne.Id = postModel.Id;
            newOne.Gender = postModel.Gender;
            newOne.hmo = postModel.HMO;
            return await _user.Add(newOne);
        }
    }
    
}
