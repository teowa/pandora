using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ManagedDatabases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ManagedDatabaseStatusConstant
{
    [Description("Creating")]
    Creating,

    [Description("Inaccessible")]
    Inaccessible,

    [Description("Offline")]
    Offline,

    [Description("Online")]
    Online,

    [Description("Restoring")]
    Restoring,

    [Description("Shutdown")]
    Shutdown,

    [Description("Updating")]
    Updating,
}
