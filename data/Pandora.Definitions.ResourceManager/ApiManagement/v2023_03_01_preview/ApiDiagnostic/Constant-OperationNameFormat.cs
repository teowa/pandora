using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.ApiDiagnostic;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperationNameFormatConstant
{
    [Description("Name")]
    Name,

    [Description("Url")]
    Url,
}
