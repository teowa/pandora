using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_09_01.PacketCoreControlPlanes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum InstallationReasonConstant
{
    [Description("ControlPlaneAccessInterfaceHasChanged")]
    ControlPlaneAccessInterfaceHasChanged,

    [Description("ControlPlaneAccessVirtualIpv4AddressesHasChanged")]
    ControlPlaneAccessVirtualIPvFourAddressesHasChanged,

    [Description("NoAttachedDataNetworks")]
    NoAttachedDataNetworks,

    [Description("NoPacketCoreDataPlane")]
    NoPacketCoreDataPlane,

    [Description("NoSlices")]
    NoSlices,

    [Description("PublicLandMobileNetworkIdentifierHasChanged")]
    PublicLandMobileNetworkIdentifierHasChanged,

    [Description("UserPlaneAccessInterfaceHasChanged")]
    UserPlaneAccessInterfaceHasChanged,

    [Description("UserPlaneAccessVirtualIpv4AddressesHasChanged")]
    UserPlaneAccessVirtualIPvFourAddressesHasChanged,

    [Description("UserPlaneDataInterfaceHasChanged")]
    UserPlaneDataInterfaceHasChanged,
}
