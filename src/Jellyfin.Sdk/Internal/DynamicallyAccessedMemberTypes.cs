#if !NET5_0_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// The member types used with <see cref="DynamicallyAccessedMembersAttribute"/> on netstandard.
/// </summary>
[Flags]
internal enum DynamicallyAccessedMemberTypes
{
    None = 0,
    PublicFields = 0x0020,
}
#endif
