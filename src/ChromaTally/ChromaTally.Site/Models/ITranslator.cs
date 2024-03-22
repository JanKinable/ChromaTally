namespace ChromaTally.Site.Models;

public interface ITranslator
{
    string TranslateSubCategory(SubCategoryType subCategoryType);
    string TranslateUnitType(UnitType? unitType);
}

public class Translator : ITranslator
{
    public string TranslateSubCategory(SubCategoryType subCategoryType) => subCategoryType switch
    {
        SubCategoryType.SweetToppings => "Zoet beleg",
        SubCategoryType.Cheese => "Kaas",
        SubCategoryType.Diary => "Melkproducten Natuur",
        SubCategoryType.Grains => "Brood en granen",
        SubCategoryType.Sauces => "Sauzen",
        SubCategoryType.FatsOilsAndNuts => "Vetten, Olie en noten",
        SubCategoryType.Patatoes => "Aardappelen",
        SubCategoryType.Fish => "Vis",
        SubCategoryType.FruitAndVegetables => "Fruit en groenten",
        SubCategoryType.Meat => "Vlees en vleeswaren",
        SubCategoryType.VegiMeat => "Vegitarische producten",
        _ => "undefined"
    };


    public string TranslateUnitType(UnitType? unitType) => unitType.HasValue ? unitType.Value.ToString() : "Undefined";
}