#if !NET5_0_OR_GREATER
// The trimming annotations are not part of netstandard. The trimmer matches them by name, so this copy keeps one
// set of method signatures for every target framework.
namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(
    AttributeTargets.Field | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct,
    Inherited = false)]
internal sealed class DynamicallyAccessedMembersAttribute : Attribute
{
    public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
        => MemberTypes = memberTypes;

    public DynamicallyAccessedMemberTypes MemberTypes { get; }
}
#endif
