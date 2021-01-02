using Feedbacks.CollectorInterface.Response;
using Feedbacks.CollectorInterface.Users;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Feedbacks.Collector.API.Controllers
{
    /// <summary>
    /// Handles all kinds of user business
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [EnableCors("AllowFCAPIOrigin")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ILogger _logger;

        public UsersController(
            IUsersRepository usersRepository,
            ILogger logger)
        {
            this._usersRepository = usersRepository;
            this._logger = logger;
        }

        /// <summary>
        /// Returns all users
        /// </summary>
        /// <returns></returns>
        // GET: api/<UsersController>
        [HttpGet]
        [ProducesResponseType(typeof(IFCRootResponse<IFCResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<ActionResult<IFCRootResponse<IFCResponse>>> Get()
        {
            return Ok(await _usersRepository.GetUsers());
        }

        /// <summary>
        /// Returns specific users
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IFCRootResponse<IFCResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<ActionResult<IFCRootResponse<IFCResponse>>> Get(string id)
        {
            return Ok(await _usersRepository.GetUser(id));
        }

        /// <summary>
        /// Add users
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        // POST api/<UsersController>
        [HttpPost]
        [ProducesResponseType(typeof(IFCResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<ActionResult<IFCResponse>> Post([FromBody] IUser user)
        {
            return Ok(await _usersRepository.AddUser(user));
        }

        /// <summary>
        /// Updates user info
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(IFCResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<ActionResult<IFCResponse>> Put(string userId, [FromBody] IUser user)
        {
            return Ok(await _usersRepository.UpdateUser(userId, user));
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(IFCResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<ActionResult<IFCResponse>> Delete(string userId)
        {
            return Ok(await _usersRepository.DeleteUser(userId));
        }
    }
}
