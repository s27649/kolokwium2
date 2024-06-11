using Kolos.DTO_s;
using Kolos.Repositories;

namespace Kolos.Services;

public class CharacterService:ICharacterService
{

    public readonly ICharacterRepository _repository;

    public CharacterService(ICharacterRepository repository)
    {
        _repository = repository;
    }

    public async Task<CharacterDto> GetCharacters(int id)
    {
        var characters = await _repository.GetCharacters(id);
        if (characters == null)
        {
            throw new Exception("No characters with this id");
        }
        var backpacks = characters.Backpacks.Select(b => new BackpackDto()
        {
            ItemName = b.Item.Name,
            ItemWeight = b.Item.Weight,
            Amount = b.Amount
        }).ToList();

        var titles = characters.CharacterTitles.Select(t => new CharacterTitleDto()
        {
            Title = t.Title.Name,
            AquiredAt = t.AcquiredAt
        }).ToList();
        
        var charactersInfo = new CharacterDto()
        {
            FirstName = characters.FirstName,
            LastName = characters.LastName,
            CurrentWeight = characters.CurrentWeight,
            MaxWeight = characters.MaxWeight,
            BackpackItems = backpacks,
            Titles = titles
        };
        return charactersInfo;
    }
}