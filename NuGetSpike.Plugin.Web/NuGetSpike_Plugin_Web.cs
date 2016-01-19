using NuGetSpike.Plugin.Resource;
namespace NuGetSpike.Plugin.Web
{
    public interface NuGetSpike_Plugin_Web
    {
        NuGetSpike_Plugin_Resource IsRequired();
        WebReferencedProject.WebReferencedProject IsReferenced();
    }
}
