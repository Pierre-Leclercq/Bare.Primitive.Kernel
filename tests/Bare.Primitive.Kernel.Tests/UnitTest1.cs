namespace Bare.Primitive.Kernel.Tests;

public class KernelUnitTests
{
    [Fact]
    public void Identity_Name_Is_Stable()
    {
        Assert.Equal("Bare.Primitive.Kernel", KernelIdentity.Name);
    }

    [Fact]
    public void SystemClock_Returns_A_Recent_UtcNow()
    {
        var sut = new SystemClock();

        var before = DateTimeOffset.UtcNow;
        var value = sut.UtcNow;
        var after = DateTimeOffset.UtcNow;

        Assert.InRange(value, before.AddSeconds(-1), after.AddSeconds(1));
    }

    [Fact]
    public void SystemGuidProvider_Returns_Non_Empty_Guid()
    {
        var sut = new SystemGuidProvider();

        var value = sut.NewGuid();

        Assert.NotEqual(Guid.Empty, value);
    }

    [Fact]
    public void SystemGuidProvider_Returns_Different_Values_On_Consecutive_Calls()
    {
        var sut = new SystemGuidProvider();

        var first = sut.NewGuid();
        var second = sut.NewGuid();

        Assert.NotEqual(first, second);
    }

    [Fact]
    public void SystemGuidProvider_Implements_Abstraction_Contract()
    {
        var sut = new SystemGuidProvider();

        Assert.IsAssignableFrom<IGuidProvider>(sut);
    }
}




