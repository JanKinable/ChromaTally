namespace ChromaTally.Site.Data.Models;

public record LookupTable(List<LookupItem> Items) : ILookupTable
{
    public LookupTable() : this(new List<LookupItem>())
    {
    }
}
