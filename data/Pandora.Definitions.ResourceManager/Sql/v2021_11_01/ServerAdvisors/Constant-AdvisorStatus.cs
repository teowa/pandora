using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ServerAdvisors;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AdvisorStatusConstant
{
    [Description("GA")]
    GA,

    [Description("LimitedPublicPreview")]
    LimitedPublicPreview,

    [Description("PrivatePreview")]
    PrivatePreview,

    [Description("PublicPreview")]
    PublicPreview,
}
