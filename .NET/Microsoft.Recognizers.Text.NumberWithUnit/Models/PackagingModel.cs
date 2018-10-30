using System.Collections.Generic;

using Microsoft.Recognizers.Text.Number;

namespace Microsoft.Recognizers.Text.NumberWithUnit
{
    public class PackagingModel : AbstractNumberWithUnitModel
    {
        public PackagingModel(Dictionary<IExtractor, IParser> extractorParserDic)
            : base(extractorParserDic)
        {
        }

        public override string ModelTypeName => "packaging";
    }
}