using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes;

public sealed record AxisRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        247,
        25,
        157,
        1,
        50,
        254,
        158,
        125,
        188,
        66,
        0,
        101,
        214,
        150,
        50,
        194,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _chartIdHash;

    private readonly IDeterminedHash _legendHash;

    public AxisRelationalModelHash(IAxisRelationalModel model)
        : this(model.Id, model.ChartId, model.Legend) { }

    public AxisRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend
    ) : this(
            new DeterminedHash(id),
            chartId,
            legend
    )
    { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend
    ) : this(
            idHash,
            new DeterminedHash(chartId),
            legend
    )
    { }

    public AxisRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend
    ) : this(
            id,
            chartIdHash,
            new DeterminedHash(legend)
    )
    { }

    public AxisRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash
    ) : this(
            new DeterminedHash(id),
            chartId,
            legendHash
    )
    { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend
    ) : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend)
    )
    { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash
    ) : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash
    )
    { }

    public AxisRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash
    ) : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash
    )
    { }

    public AxisRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash
    )
    {
        _idHash = idHash;
        _chartIdHash = chartIdHash;
        _legendHash = legendHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_chartIdHash).Concat(_legendHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
