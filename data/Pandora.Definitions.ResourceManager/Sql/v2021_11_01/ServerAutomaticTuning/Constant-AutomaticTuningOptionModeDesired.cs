using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ServerAutomaticTuning;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AutomaticTuningOptionModeDesiredConstant
{
    [Description("Default")]
    Default,

    [Description("Off")]
    Off,

    [Description("On")]
    On,
}
