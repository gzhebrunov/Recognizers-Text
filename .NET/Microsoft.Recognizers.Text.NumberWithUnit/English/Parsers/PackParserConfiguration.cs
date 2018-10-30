using System.Globalization;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English
{
    public class PackParserConfiguration : EnglishNumberWithUnitParserConfiguration
    {
        public PackParserConfiguration() : this(new CultureInfo(Culture.English)) { }

        public PackParserConfiguration(CultureInfo ci) : base(ci)
        {
            this.BindDictionary(PackExtractorConfiguration.PackSuffixList);
            this.BindDictionary(PackExtractorConfiguration.PackPrefixList);
        }
    }
}
