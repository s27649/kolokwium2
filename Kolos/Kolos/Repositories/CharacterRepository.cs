using Kolos.Context;
using Kolos.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos.Repositories;

public class CharacterRepository:ICharacterRepository
{
    private readonly DatabaseContext _context;

    public CharacterRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Character?> GetCharacters(int id)
    {
        return await _context.Characters
            .Include(ch => ch.Backpacks)
            .ThenInclude(b=> b.Item)
            .Include(ch => ch.CharacterTitles)
            .ThenInclude(ch => ch.Title)
            .FirstOrDefaultAsync(ch => ch.Id == id);
    }
}