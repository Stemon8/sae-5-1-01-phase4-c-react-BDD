﻿using backend.Data.Models;
using backend.FormModels;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaeController : ControllerBase
    {
        public readonly ISaeService _saeService;

        public SaeController(ISaeService saeService)
        {
            _saeService = saeService;
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddSae(SaeForm saeForm)
        {
            try
            {
                _saeService.CreateSae(saeForm);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("user/{id}")]
        [Authorize]
        public ActionResult<List<Sae>> GetSaesByUserId(Guid id)
        {
            var saes = _saeService.GetSaeByUserId(id);

            if (saes == null)
            {
                return NotFound();
            }

            return saes;
        }
    }
}
