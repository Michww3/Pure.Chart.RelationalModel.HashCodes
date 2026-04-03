using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RelationalModel.HashCodes;

public sealed record ChartTypeRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _nameHash;

    public ChartTypeRelationalModelHash(IChartTypeRelationalModel model)
        : this(model.Id, model.Name) { }

    public ChartTypeRelationalModelHash(IGuid id, IString name)
    : this(new DeterminedHash(id), name) { }

    public ChartTypeRelationalModelHash(IDeterminedHash idHash, IString name)
        : this(idHash, new DeterminedHash(name)) { }

    public ChartTypeRelationalModelHash(IGuid id, IDeterminedHash nameHash)
        : this(new DeterminedHash(id), nameHash) { }

    public ChartTypeRelationalModelHash(IDeterminedHash idHash, IDeterminedHash nameHash)
    {
        _idHash = idHash;
        _nameHash = nameHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_nameHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
