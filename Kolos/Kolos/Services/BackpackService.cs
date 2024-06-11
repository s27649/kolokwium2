using Kolos.Context;
using Kolos.DTO_s;
using Kolos.Models;
using Kolos.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Kolos.Services;

public class BackpackService : IBackpackService
{
    
    private readonly DatabaseContext _context;

    public BackpackService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<NewBackpackDto>> AddBackpack(List<int> idItem, int IdCharacter)
    {
        var items = new List<NewBackpackDto>();
        foreach (var ids in idItem)
        {
            _context.Backpacks.Add(new Backpack()
            {
                CharacterId = IdCharacter,
                ItemId = ids,
                Amount = 1
            });
        }

        await _context.SaveChangesAsync();
        return items;
    }
    
}