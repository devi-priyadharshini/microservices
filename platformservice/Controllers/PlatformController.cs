using Microsoft.AspNetCore.Mvc;
using platformservice.Data;
using AutoMapper;
using System.Collections.Generic;
using platformservice.Dtos;
using platformservice.Model;
using System;

namespace platformservice.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {

        private readonly IPlatformRepo _platformRepo;
        private readonly IMapper _autoMapper;

        public PlatformController(IPlatformRepo platformRepo, IMapper autoMapper)
        {
            _platformRepo = platformRepo;
            _autoMapper = autoMapper;
        }

        [HttpGet]
        public ActionResult GetAllPlatorms()
        {
            return Ok(_autoMapper.Map<IEnumerable<Platform>, IEnumerable<PlatformReadData>>(_platformRepo.GetAllPlatforms()));
        }

        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult GetPlatformById(int id)
        {
            var platform = _platformRepo.GetPlatformById(id);
            if (platform == null)
                return NotFound();

            return Ok(_autoMapper.Map<Platform, PlatformReadData>(platform));
        }


        [HttpPost]
        public ActionResult CreateNewPlatform(PlatformCreateData newPlatform)
        {
            var platform = _autoMapper.Map<PlatformCreateData, Platform>(newPlatform);
            _platformRepo.CreatePlatform(platform);

            var platformReadDto = _autoMapper.Map<Platform, PlatformReadData>(_platformRepo.GetPlatformById(platform.ID));
            return CreatedAtRoute(nameof(GetPlatformById), new
            {
                Id = platform.ID
            }, platformReadDto);
        }

    }

}
