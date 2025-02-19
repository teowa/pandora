using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.KeyVault.v2023_07_01.ManagedHsms;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GeoReplicationRegionProvisioningStateConstant
{
    [Description("Cleanup")]
    Cleanup,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Preprovisioning")]
    Preprovisioning,

    [Description("Provisioning")]
    Provisioning,

    [Description("Succeeded")]
    Succeeded,
}
