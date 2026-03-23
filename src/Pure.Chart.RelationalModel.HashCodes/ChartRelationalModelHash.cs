using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes;

public sealed record ChartRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _titleHash;

    private readonly IDeterminedHash _descriptionHash;

    private readonly IDeterminedHash _typeIdHash;

    private readonly IDeterminedHash _xAxisIdHash;

    private readonly IDeterminedHash _yAxisIdHash;

    public ChartRelationalModelHash(IChartRelationalModel model)
        : this(
            model.Id,
            model.Title,
            model.Description,
            model.TypeId,
            model.XAxisId,
            model.YAxisId
        )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    )
        : this(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId),
            new DeterminedHash(xAxisId),
            new DeterminedHash(yAxisId)
        )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    )
    {
        _idHash = idHash;
        _titleHash = titleHash;
        _descriptionHash = descriptionHash;
        _typeIdHash = typeIdHash;
        _xAxisIdHash = xAxisIdHash;
        _yAxisIdHash = yAxisIdHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_titleHash)
                .Concat(_descriptionHash)
                .Concat(_typeIdHash)
                .Concat(_xAxisIdHash)
                .Concat(_yAxisIdHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
