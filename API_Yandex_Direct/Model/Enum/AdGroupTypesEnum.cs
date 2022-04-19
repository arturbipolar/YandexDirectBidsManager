﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Тип группы задается при создании и недоступен для изменения.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdGroupTypesEnum : byte
    {
        /// <summary>
        /// группа текстово-графических объявлений.
        ///<para> Группа имеет только параметры, общие для всех типов групп.</para>
        ///<para>Группа может иметь дочерние объекты — объявления, ключевые фразы и условия нацеливания на аудиторию. Для группы можно задать корректировки ставок.</para>
        /// </summary>
        TEXT_AD_GROUP,
        /// <summary>
        /// группа для рекламы мобильных приложений.
        ///<para> Для группы этого типа необходимо дополнительно указать ссылку на приложение в магазине приложений AppStore или Google Play, а также типы устройств, типы подключения к интернету и минимальную версию операционной системы, на которых может быть показано объявление. </para>
        /// </summary>
        MOBILE_APP_AD_GROUP,
        /// <summary>
        /// группа динамических объявлений.
        ///<para>Существуют два подтипа групп динамических объявлений</para>
        /// </summary>
        DYNAMIC_TEXT_AD_GROUP
    }
}