using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repository;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IWalkRepository walkRepository;
        private readonly IMapper mapper;

        public WalksController(IWalkRepository walkRepository, IMapper mapper)
        {
            this.walkRepository = walkRepository;
            this.mapper = mapper;
        }

        //CREATE Walk
        //POST: https://localhost:7036/api/walks
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {
            //Map AddWalkRequestDto DTO to Walk Domain Model
            var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);

            await walkRepository.CreateAsync(walkDomainModel);

            //Map Domain Model to Dto
            var walkDto = mapper.Map<WalkDto>(walkDomainModel);

            return Ok(walkDto);         
        }

        //Get Walk
        //GET: https://localhost:7036/api/walks?filterOn=Name&filterQuery=Track&sortBy=Name&isAscending=true&pageNumber=1&pageSize=10
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            var walkDomainModel = await walkRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize);

            //Map Domain Model to Dto
            var walkDto = mapper.Map<List<WalkDto>>(walkDomainModel);

            return Ok(walkDto);
        }

        //Get Walk By Id
        //GET: https://localhost:7036/api/walks/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.GetByIdAsync(id);

            if(walkDomainModel == null)
            {
                return NotFound();
            }

            //Map Domain Model to Dto
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }

        //Update Walk By Id
        //PUT: https://localhost:7036/api/walks/{id}
        [HttpPut]
        [Route("{id}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWalkRequestDto updateWalkRequestDto)
        {
            //Map DTO to Domain Model
            var walkDomainModel = mapper.Map<Walk>(updateWalkRequestDto);

            walkDomainModel = await walkRepository.UpdateAsync(id, walkDomainModel);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Models to DTO
            var walkDto = mapper.Map<WalkDto>(walkDomainModel);

            return Ok(walkDto);
        }

        //Delete Walk
        //DELETE: https://localhost:7036/api/walks/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.DeleteAsync(id);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Models to DTO
            var walkDto = mapper.Map<WalkDto>(walkDomainModel);

            return Ok(walkDto);
        }
    }
}
