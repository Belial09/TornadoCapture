using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TornadoCapture_v2.Klassen
{
    public static class Enums
    {
        public enum OcrLanguages
        {
            [Description("English")]
            ENG,
            [Description("German")]
            DEU,
            [Description("Ukrainian")]
            UKR,
            [Description("Turkish")]
            TUR,
            [Description("Thai")]
            THA,
            [Description("Tamil")]
            TAM,
            [Description("Swedish")]
            SWE,
            [Description("Albanian")]
            SQI,
            [Description("Spanish")]
            SPA,
            [Description("Slovenian")]
            SLV,
            [Description("Slovakian")]
            SLK,
            [Description("Romanian")]
            RON,
            [Description("Portuguese")]
            POR,
            [Description("Polish")]
            POL,
            [Description("Norwegian")]
            NOR,
            [Description("Durch")]
            NLD,
            [Description("Maltese")]
            MLT,
            [Description("Mayalayam")]
            MAL,
            [Description("Macedonian")]
            MKD,
            [Description("Lithuanian")]
            LIT,
            [Description("Latvian")]
            LAV,
            [Description("Korean")]
            KOR,
            [Description("Italian")]
            ITA,
            [Description("Icelandic")]
            ISL,
            [Description("Indonesian")]
            IND,
            [Description("Hungarian")]
            HUN,
            [Description("Croatian")]
            HRV,
            [Description("Hindi")]
            HIN,
            [Description("Hebrew")]
            HEB,
            [Description("Frankish")]
            FRK,
            [Description("French")]
            FRA,
            [Description("Finnish")]
            FIN,
            [Description("Estonian")]
            EST,
            [Description("MATH / EQUATION")]
            EQU,
            [Description("Greek")]
            ELL,
            [Description("Danish")]
            DAN,
            [Description("Czech")]
            CES,
            [Description("Bulgarian")]
            BUL,
            [Description("Bengali")]
            BEN,
            [Description("Belarusian")]
            BEL,
            [Description("Azerbaijani")]
            AZE,
            [Description("Arabic")]
            ARA,
            [Description("African")]
            AFR,
            [Description("Japanese")]
            JPN,
            [Description("Chinese Simplified")]
            CHI_SIM,
            [Description("Chinese Traditional")]
            CHI_TRA,
            [Description("Russian")]
            RUS,
            [Description("Vietnamese")]
            VIE
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public static T EnumFromString<T>(string value) where T : struct
        {
            string noSpace = value.Replace(" ", "");
            if (Enum.GetNames(typeof(T)).Any(x => x.ToString().Equals(noSpace)))
            {
                return (T)Enum.Parse(typeof(T), noSpace);
            }
            return default(T);
        }

    }
}
