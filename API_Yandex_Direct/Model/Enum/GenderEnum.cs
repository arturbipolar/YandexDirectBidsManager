using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderEnum : byte { GENDER_MALE, GENDER_FEMALE }
}
