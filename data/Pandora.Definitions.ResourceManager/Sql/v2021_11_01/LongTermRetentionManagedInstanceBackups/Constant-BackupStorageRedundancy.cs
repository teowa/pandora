using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.LongTermRetentionManagedInstanceBackups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BackupStorageRedundancyConstant
{
    [Description("Geo")]
    Geo,

    [Description("GeoZone")]
    GeoZone,

    [Description("Local")]
    Local,

    [Description("Zone")]
    Zone,
}
