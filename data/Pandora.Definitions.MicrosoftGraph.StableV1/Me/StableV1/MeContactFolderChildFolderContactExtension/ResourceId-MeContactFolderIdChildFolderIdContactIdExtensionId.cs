// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeContactFolderChildFolderContactExtension;

internal class MeContactFolderIdChildFolderIdContactIdExtensionId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/contactFolders/{contactFolderId}/childFolders/{contactFolderId1}/contacts/{contactId}/extensions/{extensionId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticContactFolders", "contactFolders"),
        ResourceIDSegment.UserSpecified("contactFolderId"),
        ResourceIDSegment.Static("staticChildFolders", "childFolders"),
        ResourceIDSegment.UserSpecified("contactFolderId1"),
        ResourceIDSegment.Static("staticContacts", "contacts"),
        ResourceIDSegment.UserSpecified("contactId"),
        ResourceIDSegment.Static("staticExtensions", "extensions"),
        ResourceIDSegment.UserSpecified("extensionId")
    };
}
