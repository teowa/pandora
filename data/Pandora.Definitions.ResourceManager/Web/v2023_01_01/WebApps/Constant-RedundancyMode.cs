using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.WebApps;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RedundancyModeConstant
{
    [Description("ActiveActive")]
    ActiveActive,

    [Description("Failover")]
    Failover,

    [Description("GeoRedundant")]
    GeoRedundant,

    [Description("Manual")]
    Manual,

    [Description("None")]
    None,
}
