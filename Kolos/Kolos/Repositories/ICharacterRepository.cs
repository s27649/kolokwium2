using Kolos.Models;

namespace Kolos.Repositories;

public interface ICharacterRepository
{
    public Task<Character?> GetCharacters(int id);
}