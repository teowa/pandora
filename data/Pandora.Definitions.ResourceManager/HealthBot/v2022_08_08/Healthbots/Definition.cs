using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HealthBot.v2022_08_08.Healthbots;

internal class Definition : ResourceDefinition
{
    public string Name => "Healthbots";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new BotsCreateOperation(),
        new BotsDeleteOperation(),
        new BotsGetOperation(),
        new BotsListOperation(),
        new BotsListByResourceGroupOperation(),
        new BotsListSecretsOperation(),
        new BotsRegenerateApiJwtSecretOperation(),
        new BotsUpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(SkuNameConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(HealthBotModel),
        typeof(HealthBotKeyModel),
        typeof(HealthBotKeysResponseModel),
        typeof(HealthBotPropertiesModel),
        typeof(HealthBotUpdateParametersModel),
        typeof(KeyVaultPropertiesModel),
        typeof(SkuModel),
    };
}
