using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes;

public sealed record SeriesRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _chartIdHash;

    private readonly IDeterminedHash _legendHash;

    private readonly IDeterminedHash _xAxisSourceHash;

    private readonly IDeterminedHash _yAxisSourceHash;

    public SeriesRelationalModelHash(ISeriesRelationalModel model)
        : this(
            model.Id,
            model.ChartId,
            model.Legend,
            model.XAxisSource,
            model.YAxisSource
        )
    { }

    public SeriesRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IString yAxisSource
    )
        : this(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource)
        )
    { }

    public SeriesRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash
    )
    {
        _idHash = idHash;
        _chartIdHash = chartIdHash;
        _legendHash = legendHash;
        _xAxisSourceHash = xAxisSourceHash;
        _yAxisSourceHash = yAxisSourceHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_chartIdHash)
                .Concat(_legendHash)
                .Concat(_xAxisSourceHash)
                .Concat(_yAxisSourceHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
