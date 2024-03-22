namespace ChromaTally.Site.Models;

public class Nutrition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CategoryColor Color { get; set; }
    public SubCategoryType SubCategory { get; set; }

    public UnitType Unit { get; set; }
    public double Value { get; set; }

    public BCMUnitType BCMPortionUnit { get; set; }
    public double BCMPortionValue { get; set; }

    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Fibers { get; set; }
    public int Energy { get; set; }
}
