using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedHatOpenShift.v2022_04_01.OpenShiftClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EncryptionAtHostConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
