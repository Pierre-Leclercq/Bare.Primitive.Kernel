namespace Bare.Primitive.Kernel;

public interface IClock
{
    DateTimeOffset UtcNow { get; }
}
