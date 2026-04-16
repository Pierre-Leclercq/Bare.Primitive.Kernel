namespace Bare.Primitive.Kernel;

public sealed class SystemGuidProvider : IGuidProvider
{
    public Guid NewGuid() => Guid.NewGuid();
}
