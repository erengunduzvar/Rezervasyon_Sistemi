using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Services
{
    public static class ServiceClass
    {
        public static string cityShortcutToFullName(string shrtcut)
        {
            shrtcut = shrtcut.ToLower();
            switch(shrtcut)
            {
                case "is":
                    shrtcut = "Istanbul";
                    break;
                case "koc":
                    shrtcut = "Kocaeli";
                    break;
                case "bi":
                    shrtcut = "Bilecik";
                    break;
                case "es":
                    shrtcut = "Eskişehir";
                    break;
                case "an":
                    shrtcut = "Ankara";
                    break;
                case "kon":
                    shrtcut = "Konya";
                    break;
            }
            return shrtcut;
        }

        public static string cityToFullNameToShortcut(string fullname)
        {
            fullname = fullname.ToLower();
            switch (fullname)
            {
                case "istanbul":
                    fullname = "is";
                    break;
                case "ıstanbul":
                    fullname = "is";
                    break;
                case "kocaeli":
                    fullname = "koc";
                    break;
                case "bilecik":
                    fullname = "bi";
                    break;
                case "eskişehir":
                    fullname = "es";
                    break;
                case "ankara":
                    fullname = "an";
                    break;
                case "konya":
                    fullname = "kon";
                    break;
            }
            return fullname;
        }
    }
}
