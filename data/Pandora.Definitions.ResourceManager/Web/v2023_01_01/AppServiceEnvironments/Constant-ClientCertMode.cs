using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.AppServiceEnvironments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ClientCertModeConstant
{
    [Description("Optional")]
    Optional,

    [Description("OptionalInteractiveUser")]
    OptionalInteractiveUser,

    [Description("Required")]
    Required,
}
