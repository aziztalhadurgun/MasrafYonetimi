using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DurumEnumHelper
    {
        public static string GetText(byte id)
        {
            switch (id)
            {
                case 1:
                    return "Onay Bekliyor";
                case 2:
                    return "Reddedildi";
                case 3:
                    return "Düzeltilecek";
                case 4:
                    return "Ödendi";
                case 5:
                    return "Onaylandı";
                default:
                    return string.Empty;
            }
        }
        public static string GetText(DurumEnum e)
        {
            switch (e)
            {
                case DurumEnum.OnayBekliyor:
                    return "Onay Bekliyor";
                case DurumEnum.Reddedildi:
                    return "Reddedildi";
                case DurumEnum.Duzeltilecek:
                    return "Düzeltilecek";
                case DurumEnum.Odendi:
                    return "Ödendi";
                case DurumEnum.Onaylandı:
                    return "Onaylandı";
                default:
                    return string.Empty;
            }
        }
    }
}
