using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Get.AdGroup
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DynamicTextAdGroupFieldEnum : byte
    {
        DomainUrl,
        DomainUrlProcessingStatus
    }
}
