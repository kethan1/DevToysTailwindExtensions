using DevToys.Api;
using System.ComponentModel.Composition;

namespace Kethan.DevToys.Tailwind.ClosestColor;

[Export(typeof(IResourceAssemblyIdentifier))]
[Name(nameof(ClosestColorResourceAssemblyIdentifier))]
internal sealed class ClosestColorResourceAssemblyIdentifier : IResourceAssemblyIdentifier
{
    public ValueTask<FontDefinition[]> GetFontDefinitionsAsync()
    {
        throw new NotImplementedException();
    }
}