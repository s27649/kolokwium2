using Kolos.DTO_s;

namespace Kolos.Services;

public interface IBackpackService
{
    public Task<List<NewBackpackDto>> AddBackpack(List<int> idItem, int IdCharacter);
}