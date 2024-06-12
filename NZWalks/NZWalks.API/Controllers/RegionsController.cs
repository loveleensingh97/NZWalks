using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repository;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        //private readonly NZWalksDbContext _dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(/* NZWalksDbContext dbContext, */ IRegionRepository regionRepository, IMapper mapper)
        {
            //this._dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        //GET ALL REGIONS
        //GET: https://localhost:7036/api/regions
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //Get Data from Database - Domain Models
            var regionsDomain = await regionRepository.GetAllAsync();

            //Map Domain Models to DTOs & Return DTOs
            return Ok(mapper.Map<List<RegionDto>>(regionsDomain));
        }

        //GET Region By Id
        //GET: https://localhost:7036/api/regions/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            //var region = _dbContext.Regions.Find(id);//Find method works only with primary key
            //Get Region Domain Model from Database
            var regionDomain = await regionRepository.GetByIdAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            //Map Region Domain Model to Region DTO & Return DTO back to the client
            return Ok(mapper.Map<RegionDto>(regionDomain));
        }

        //POST: To Create New Region
        //POST: https://localhost:7036/api/regions
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            //Map or Convert DTOs to Domain Model
            var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

            //Use Domain Model to Create Region
            regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);

            //Map Domain Model back to DTO
            var regionDto = mapper.Map<RegionDto>(regionDomainModel);

            return CreatedAtAction(nameof(GetById), new { id = regionDomainModel.Id }, regionDto);
        }

        //Update region
        //PUT: https://localhost:7036/api/regions/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            //Map DTO to Domain Model
            var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

            //Check if region exists
            regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

            if(regionDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Models to DTO
            var regionDto = mapper.Map<RegionDto> (regionDomainModel);

            return Ok(regionDto);
        }

        //Delete Region
        //DELETE: https://localhost:7036/api/regions/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionDomainModel = await regionRepository.DeleteAsync(id);

            if(regionDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Models to DTO
            var regionDto = mapper.Map<RegionDto>(regionDomainModel);

            return Ok(regionDto);
        }
    }
}
