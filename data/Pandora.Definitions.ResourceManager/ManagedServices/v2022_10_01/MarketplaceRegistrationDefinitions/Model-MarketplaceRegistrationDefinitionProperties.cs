using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ManagedServices.v2022_10_01.MarketplaceRegistrationDefinitions;


internal class MarketplaceRegistrationDefinitionPropertiesModel
{
    [JsonPropertyName("authorizations")]
    [Required]
    public List<AuthorizationModel> Authorizations { get; set; }

    [JsonPropertyName("eligibleAuthorizations")]
    public List<EligibleAuthorizationModel>? EligibleAuthorizations { get; set; }

    [JsonPropertyName("managedByTenantId")]
    [Required]
    public string ManagedByTenantId { get; set; }

    [JsonPropertyName("offerDisplayName")]
    public string? OfferDisplayName { get; set; }

    [JsonPropertyName("planDisplayName")]
    public string? PlanDisplayName { get; set; }

    [JsonPropertyName("publisherDisplayName")]
    public string? PublisherDisplayName { get; set; }
}
