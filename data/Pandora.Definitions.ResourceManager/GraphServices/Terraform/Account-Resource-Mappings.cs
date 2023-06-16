using System.Collections.Generic;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Mappings;
using Pandora.Definitions.ResourceManager.GraphServices.v2023_04_13.Graphservicesprods;

namespace Pandora.Definitions.ResourceManager.GraphServices.Terraform;

public class AccountResourceMappings : TerraformMappingDefinition
{
    public List<MappingType> Mappings => new List<MappingType>
    {
        Mapping.FromSchema<AccountResourceSchema>(s => s.Name).ToResourceIdSegmentNamed("accountName"),
        Mapping.FromSchema<AccountResourceSchema>(s => s.ResourceGroupName).ToResourceIdSegmentNamed("resourceGroupName"),

        Mapping.FromSchema<AccountResourceSchema>(s => s.AppId).ToSdkField<AccountResourcePropertiesModel>(m => m.AppId).Direct(),
        Mapping.FromSchema<AccountResourceSchema>(s => s.BillingPlanId).ToSdkField<AccountResourcePropertiesModel>(m => m.BillingPlanId).Direct(),
        Mapping.FromSchema<AccountResourceSchema>(s => s.Location).ToSdkField<AccountResourceModel>(m => m.Location).Direct(),
        Mapping.FromSchema<AccountResourceSchema>(s => s.Tags).ToSdkField<AccountResourceModel>(m => m.Tags).Direct(),
        Mapping.FromSchemaModel<AccountResourceSchema>().ToSdkField<AccountResourceModel>(m => m.Properties).ModelToModel(),
    };
}
