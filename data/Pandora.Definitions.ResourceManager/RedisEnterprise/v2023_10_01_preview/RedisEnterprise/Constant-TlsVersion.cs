using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2023_10_01_preview.RedisEnterprise;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TlsVersionConstant
{
    [Description("1.1")]
    OnePointOne,

    [Description("1.2")]
    OnePointTwo,

    [Description("1.0")]
    OnePointZero,
}
