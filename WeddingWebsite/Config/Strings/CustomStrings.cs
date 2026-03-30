using WeddingWebsite.Models.ConfigInterfaces;

namespace WeddingWebsite.Config.Strings;

public class CustomStrings : FriendlyBritishEnglish, IStringProvider
{
    // TODO: Change strings
    public new string RegistryDescription1 => "If you'd like to give us a gift, please see our preferences below.";
    public new string RegistryDescription2 => "Click on an item for more information. And please claim an item once you've decided to purchase it, to avoid multiple people buying the same thing!";
    public new string DoNotPurchaseBeforeClaiming => "Please claim an item before purchasing!";
    
    public new string? RsvpYesDescription => null;
    public new string? RsvpNoDescription => null;
}
