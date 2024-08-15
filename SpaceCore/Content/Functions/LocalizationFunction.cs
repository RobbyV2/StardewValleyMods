using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCore.Content.Functions;
internal class LocalizationFunction : BaseFunction
{
    public LocalizationFunction()
    :   base( "%" )
    {
    }

    public override SourceElement Simplify(FuncCall fcall, ContentEngine ce)
    {
        if (fcall.Parameters.Count != 1)
            throw new ArgumentException($"I18n function $ must have exactly one string parameter, at {fcall.FilePath}:{fcall.Line}:{fcall.Column}");

        return new Token()
        {
            FilePath = fcall.FilePath,
            Line = fcall.Line,
            Column = fcall.Column,
            Value = ce.Helper.Translation.Get(fcall.Parameters[0].SimplifyToToken(ce).Value),
            IsString = true,
            Context = fcall.Context,
            Uid = fcall.Uid,
        };
    }
}
