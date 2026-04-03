using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record ChartRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        240,
        25,
        157,
        1,
        33,
        204,
        173,
        118,
        154,
        25,
        172,
        225,
        208,
        94,
        8,
        159,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashTypeIdHashXAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            yAxisId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashTypeIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            xAxisId,
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDesciptionHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            typeId,
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            desciption,
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDesciptionHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDesciptionHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDesciptionHashTypeIdHashXAxisIdHashYAxisIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        ChartRelationalModelHash expected = new ChartRelationalModelHash(model);
        ChartRelationalModelHash actual = new ChartRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(desciption),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        IEnumerable hashEnumerable = new ChartRelationalModelHash(model);

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(title))
                .Concat(new DeterminedHash(desciption))
                .Concat(new DeterminedHash(typeId))
                .Concat(new DeterminedHash(xAxisId))
                .Concat(new DeterminedHash(yAxisId))
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
        IString title = new RandomString();
        IString desciption = new RandomString();
        IGuid typeId = new Guid();
        IGuid xAxisId = new Guid();
        IGuid yAxisId = new Guid();

        IChartRelationalModel model = new ChartRelationalModel(
            id,
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisId
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(title))
                .Concat(new DeterminedHash(desciption))
                .Concat(new DeterminedHash(typeId))
                .Concat(new DeterminedHash(xAxisId))
                .Concat(new DeterminedHash(yAxisId))
        );

        Assert.Equal(expectedHash, new ChartRelationalModelHash(model));
    }
}
