using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.OnlineDeployment;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EndpointComputeTypeConstant
{
    [Description("AzureMLCompute")]
    AzureMLCompute,

    [Description("Kubernetes")]
    Kubernetes,

    [Description("Managed")]
    Managed,
}
