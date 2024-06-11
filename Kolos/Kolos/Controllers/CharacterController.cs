using Kolos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController:ControllerBase
{
    private readonly ICharacterService _service;
    private readonly IBackpackService _backpackService;

    public CharacterController(ICharacterService service, IBackpackService backpackService)
    {
        _service = service;
        _backpackService = backpackService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacters(int id)
    {
        var character = await _service.GetCharacters(id);
        return Ok(character);
    }
    
}