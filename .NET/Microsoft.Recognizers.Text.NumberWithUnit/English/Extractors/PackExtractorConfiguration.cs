using System.Collections.Immutable;
using System.Globalization;

using Microsoft.Recognizers.Definitions.English;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English
{
    public class PackExtractorConfiguration : EnglishNumberWithUnitExtractorConfiguration
    {
        public PackExtractorConfiguration() : this(new CultureInfo(Culture.English)) { }

        public PackExtractorConfiguration(CultureInfo ci) : base(ci) { }

        public override ImmutableDictionary<string, string> SuffixList => PackSuffixList;

        public override ImmutableDictionary<string, string> PrefixList => PackPrefixList;

        public override ImmutableList<string> AmbiguousUnitList => null;

        public override string ExtractType => Constants.SYS_UNIT_PACKAGING;

        public static readonly ImmutableDictionary<string, string> PackSuffixList = NumbersWithUnitDefinitions.PackSuffixList.ToImmutableDictionary();

        public static readonly ImmutableDictionary<string, string> PackPrefixList = NumbersWithUnitDefinitions.PackPrefixList.ToImmutableDictionary();
    }
}