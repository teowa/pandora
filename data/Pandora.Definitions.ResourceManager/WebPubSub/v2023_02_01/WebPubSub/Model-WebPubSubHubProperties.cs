using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.WebPubSub.v2023_02_01.WebPubSub;


internal class WebPubSubHubPropertiesModel
{
    [JsonPropertyName("anonymousConnectPolicy")]
    public string? AnonymousConnectPolicy { get; set; }

    [JsonPropertyName("eventHandlers")]
    public List<EventHandlerModel>? EventHandlers { get; set; }

    [JsonPropertyName("eventListeners")]
    public List<EventListenerModel>? EventListeners { get; set; }
}
