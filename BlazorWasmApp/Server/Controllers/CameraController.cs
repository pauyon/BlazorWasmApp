using AutoMapper;
using BlazorWasmApp.Server.Domain.Repositories;
using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        protected ApiResponse _response;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CameraController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _response = new ApiResponse();
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Camera>>> GetAll()
        {
            var result = await _unitOfWork.CameraRepository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Camera>> GetUser(int id)
        {
            var result = await _unitOfWork.CameraRepository.Get(x => x.Id == id);

            if (result == null)
            {
                return NotFound("User not found.");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Camera>> AddUser(Camera user)
        {
            var result = await _unitOfWork.CameraRepository.Add(user);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<List<Camera>>> UpdateUser(Camera user)
        {
            var result = await _unitOfWork.CameraRepository.Update(user);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            var result = await _unitOfWork.CameraRepository.Delete(id);
            return Ok(result);
        }
    }
}
