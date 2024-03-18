using ChromaTally.Site.Models;

namespace ChromaTally.Site.Data.Models;

public class LookupItem
{
    public string Name { get; set; } = string.Empty;
    public CategoryColor Color { get; set; }
    public SubCategoryType SubCategory { get; set; }

    public Quantity? Quantity { get; set; }

    public Quantity? BCMPortion { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Fibers { get; set; }
    public int Energy { get; set; }

}
