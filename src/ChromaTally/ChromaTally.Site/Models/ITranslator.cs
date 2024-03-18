namespace ChromaTally.Site.Models;

public interface ITranslator
{
    string TranslateSubCategory(SubCategoryType subCategoryType);
    string TranslateUnitType(QuantityUnitType? quantityUnitType);
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


    public string TranslateUnitType(QuantityUnitType? quantityUnitType) => quantityUnitType switch
    {
        QuantityUnitType.Number => "stuk",
        QuantityUnitType.Milliliter => "ml",
        QuantityUnitType.Centimeter => "cm",
        QuantityUnitType.Gram => "gr",
        QuantityUnitType.Glass => "glas",
        QuantityUnitType.Tablespoon => "eetl.",
        QuantityUnitType.Coffeespoon => "koffiel.",
        QuantityUnitType.Cup => "tas",
        QuantityUnitType.Plate => "bord",
        QuantityUnitType.Slice => "plakje",
        QuantityUnitType.Bundle => "portie",
        _ => "undefined"
    };

}