using DevToys.Api;
using System.ComponentModel.Composition;
using static DevToys.Api.GUI;

namespace Kethan.DevToys.Tailwind.ClosestColor;

[Export(typeof(IGuiTool))]
[Name("ClosestColor")]                                                        // A unique, internal name of the tool.
[ToolDisplayInformation(
    IconFontName = "FluentSystemIcons",                                       // This font is available by default in DevToys
    IconGlyph = '\uE670',                                                     // An icon that represents a pizza
    GroupName = PredefinedCommonToolGroupNames.Converters,                    // The group in which the tool will appear in the side bar.
    ResourceManagerAssemblyIdentifier = nameof(ClosestColorResourceAssemblyIdentifier), // The Resource Assembly Identifier to use
    ResourceManagerBaseName = "Kethan.DevToys.Tailwind.ClosestColor.ClosestColor",                      // The full name (including namespace) of the resource file containing our localized texts
    ShortDisplayTitleResourceName = nameof(ClosestColor.ShortDisplayTitle),   // The name of the resource to use for the short display title
    LongDisplayTitleResourceName = nameof(ClosestColor.LongDisplayTitle),
    DescriptionResourceName = nameof(ClosestColor.Description),
    AccessibleNameResourceName = nameof(ClosestColor.AccessibleName))]
internal sealed class ClosestColorGui : IGuiTool
{
    public ClosestColorUtils closestColorUtils = new();
    public UIToolView View => new(Label().Style(UILabelStyle.BodyStrong).Text("Hello"));

    public void OnDataReceived(string dataTypeName, object? parsedData)
    {
        throw new NotImplementedException();
    }
}
