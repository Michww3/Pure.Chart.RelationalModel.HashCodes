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
     IString desciption,
     IGuid typeId,
     IGuid xAxisId,
     IGuid yAxisId
    ) : this(
         new DeterminedHash(id),
         title,
         desciption,
         typeId,
         xAxisId,
         yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeId,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeId,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeIdHash,
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeId,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            title,
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            new DeterminedHash(typeId),
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeIdHash,
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            new DeterminedHash(typeId),
            xAxisIdHash,
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            typeIdHash,
            new DeterminedHash(xAxisId),
            yAxisId
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeIdHash,
            xAxisId,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciption,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            new DeterminedHash(title),
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString desciption,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            new DeterminedHash(desciption),
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IGuid yAxisId
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            new DeterminedHash(yAxisId)
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IGuid xAxisId,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            typeIdHash,
            new DeterminedHash(xAxisId),
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IDeterminedHash typeIdHash,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            new DeterminedHash(id),
            titleHash,
            desciptionHash,
            typeIdHash,
            xAxisIdHash,
            yAxisIdHash
    )
    { }

    public ChartRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash desciptionHash,
        IGuid typeId,
        IDeterminedHash xAxisIdHash,
        IDeterminedHash yAxisIdHash
    ) : this(
            idHash,
            titleHash,
            desciptionHash,
            new DeterminedHash(typeId),
            xAxisIdHash,
            yAxisIdHash
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
