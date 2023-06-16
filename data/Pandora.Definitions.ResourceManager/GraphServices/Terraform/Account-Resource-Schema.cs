using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.GraphServices.Terraform;

public class AccountResourceSchema
{

    [Documentation("Customer owned application ID.")]
    [ForceNew]
    [HclName("app_id")]
    [Required]
    public string AppId { get; set; }


    [Computed]
    [Documentation("Billing Plan Id.")]
    [HclName("billing_plan_id")]
    public string BillingPlanId { get; set; }


    [Documentation("The Azure Region where the Account should exist.")]
    [ForceNew]
    [HclName("location")]
    [Required]
    public CommonSchema.Location Location { get; set; }


    [Documentation("Specifies the name of this Account.")]
    [ForceNew]
    [HclName("name")]
    [Required]
    public string Name { get; set; }


    [Documentation("Specifies the name of the Resource Group within which this Account should exist.")]
    [ForceNew]
    [HclName("resource_group_name")]
    [Required]
    public CommonSchema.ResourceGroupName ResourceGroupName { get; set; }


    [Documentation("A mapping of tags which should be assigned to the Account.")]
    [HclName("tags")]
    [Optional]
    public CommonSchema.Tags Tags { get; set; }

}
