using Kolos.DTO_s;

namespace Kolos.Services;

public interface ICharacterService
{
    public Task<CharacterDto> GetCharacters(int id);
}