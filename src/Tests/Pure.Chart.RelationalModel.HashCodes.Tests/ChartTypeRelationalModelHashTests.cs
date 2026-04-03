using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record ChartTypeRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        241,
        25,
        157,
        1,
        147,
        155,
        31,
        119,
        186,
        56,
        147,
        211,
        74,
        98,
        7,
        230,
    ];

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

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        IEnumerable hashEnumerable = new ChartTypeRelationalModelHash(model);

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(name))
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IChartTypeRelationalModel model = new ChartTypeRelationalModel(
            id,
            name
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(name))
        );

        Assert.Equal(expectedHash, new ChartTypeRelationalModelHash(model));
    }
}
