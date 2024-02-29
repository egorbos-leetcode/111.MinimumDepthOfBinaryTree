namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        Assert.Equal(2, Solution.MinDepth(Solution.BuildTree([3, 9, 20, null, null, 15, 7])));
        Assert.Equal(5, Solution.MinDepth(Solution.BuildTree([2, null, 3, null, 4, null, 5, null, 6])));
    }
}
