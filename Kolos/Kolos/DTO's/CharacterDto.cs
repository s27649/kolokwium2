namespace Kolos.DTO_s;

public class CharacterDto
{
    
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<BackpackDto> BackpackItems { get; set; } = null!;
    public ICollection<CharacterTitleDto> Titles { get; set; } = null!;
}

public class BackpackDto
{
    public string ItemName { get; set; } = null!;
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
}

public class CharacterTitleDto
{
    public DateTime AquiredAt { get; set; }
    public string Title { get; set; } = null!;
}