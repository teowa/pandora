using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetApp.v2023_07_01.NetAppAccounts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ActiveDirectoryStatusConstant
{
    [Description("Created")]
    Created,

    [Description("Deleted")]
    Deleted,

    [Description("Error")]
    Error,

    [Description("InUse")]
    InUse,

    [Description("Updating")]
    Updating,
}
