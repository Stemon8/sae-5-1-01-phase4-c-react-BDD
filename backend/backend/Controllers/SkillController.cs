﻿using backend.Data.Models;
using backend.Services.Interfaces;
using backend.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SkillController: ControllerBase
{
    private readonly ISkillService _skillService;

    public SkillController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    [HttpGet]
    [Authorize(Roles = RoleAccesses.Student)]
    public ActionResult<List<Skill>> GetSkills()
    {
        return _skillService.GetSkills();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = RoleAccesses.Student)]
    public async Task<ActionResult<Skill>> GetSkillById(Guid id)
    {
        var skill = _skillService.GetSkillById(id);

        if (skill == null)
        {
            return NotFound();
        }

        return skill;
    }

    [HttpPost]
    [Authorize(Roles = RoleAccesses.Teacher)]
    public async Task<ActionResult<Skill>> AddSkill(string name)
    {
        var skill = _skillService.AddSkill(name);

        return CreatedAtAction(
            nameof(GetSkillById),
            new { id = skill.id },
            new
            {
                skill.id,
                skill.name
            });
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = RoleAccesses.Teacher)]
    public async Task<IActionResult> RemoveSkill(Guid id)
    {
        var skill = _skillService.GetSkillById(id);

        if (skill == null)
        {
            return NotFound();
        }
        
        _skillService.RemoveSkill(id);

        return NoContent();
    }
}