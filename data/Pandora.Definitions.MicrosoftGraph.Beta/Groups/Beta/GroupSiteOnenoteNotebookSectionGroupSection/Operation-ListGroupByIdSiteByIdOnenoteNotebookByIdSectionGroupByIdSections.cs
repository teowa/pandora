// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSiteOnenoteNotebookSectionGroupSection;

internal class ListGroupByIdSiteByIdOnenoteNotebookByIdSectionGroupByIdSectionsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new GroupIdSiteIdOnenoteNotebookIdSectionGroupId();
    public override Type NestedItemType() => typeof(OnenoteSectionCollectionResponseModel);
    public override string? UriSuffix() => "/sections";
}
