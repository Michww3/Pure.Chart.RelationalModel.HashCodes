using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Chart.RelationalModel.HashCodes.Tests;

public sealed record SeriesRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        243,
        25,
        157,
        1,
        93,
        28,
        13,
        115,
        186,
        164,
        140,
        177,
        255,
        182,
        231,
        87,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            yAxisSource
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            xAxisSource,
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            legend,
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            chartId,
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        IEnumerable hashEnumerable = new SeriesRelationalModelHash(model);

        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
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
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
        );

        Assert.Equal(expectedHash, new SeriesRelationalModelHash(model));
    }
}
