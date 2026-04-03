using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record ChartTypeRelationalModelHashTests
{
    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        ChartTypeRelationalModelHash expected = new ChartTypeRelationalModelHash(model);
        ChartTypeRelationalModelHash actual = new ChartTypeRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        ChartTypeRelationalModelHash expected = new ChartTypeRelationalModelHash(model);
        ChartTypeRelationalModelHash actual = new ChartTypeRelationalModelHash(
            id,
            name
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        ChartTypeRelationalModelHash expected = new ChartTypeRelationalModelHash(model);
        ChartTypeRelationalModelHash actual = new ChartTypeRelationalModelHash(
            new DeterminedHash(id),
            name
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromNameHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        ChartTypeRelationalModelHash expected = new ChartTypeRelationalModelHash(model);
        ChartTypeRelationalModelHash actual = new ChartTypeRelationalModelHash(
            id,
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        ChartTypeRelationalModelHash expected = new ChartTypeRelationalModelHash(model);
        ChartTypeRelationalModelHash actual = new ChartTypeRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }
}
