namespace TestFarsi.Infrastructure
{
    static internal class Utilities
    {
        static Utilities()
        {

        }

        public static string ChangeTextToUnicode(string input)
        {
            string result = string.Empty;

            if (string.IsNullOrEmpty(input) == false)
            {
                for (int index = 0; index < input.Length; index++)
                {
                    var charCode = (int)input[index];

                    if (charCode == 32)
                    {
                        result = $"{ result } ";
                    }
                    else
                    {
                        int characterLocation = 0;
                        if (index == 0)
                        {
                            characterLocation = 0;
                        }
                        else if ((index == (input.Length - 1)) ||
                            (input[index + 1] == 32) ||
                            (input[index + 1] == 32 && input[index - 1] == 32))
                        {
                            characterLocation = 2;
                        }
                        else if ((input[index + 1] != 32 && input[index - 1] != 32 && input[index - 1] != 1575) ||
                            (input[index + 1] == 32 && input[index - 1] != 32 && input[index - 1] != 1575))
                        {
                            characterLocation = 1;
                        }

                        var unicodeChar = GetUnicode(charCode, characterLocation);
                        result = $"{ result }{ unicodeChar }";
                    }

                }
            }
            return Reverse(result);
        }

        static string GetUnicode(int charCode, int characterLocation)
        {
            var result = string.Empty;

            switch (characterLocation)
            {
                case 0:
                    result = GetUnicodeFirst(charCode);
                    break;

                case 1:
                    result = GetUnicodeMiddle(charCode);
                    break;

                case 2:
                    result = GetUnicodeLast(charCode);
                    break;

                default:
                    break;
            }

            return result;
        }

        static string GetUnicodeFirst(int charCode)
        {
            switch (charCode)
            {
                //الف
                case 1575:
                    return "\uFE8D";

                //ب
                case 1576:
                    return "\uFE91";

                //پ
                case 1662:
                    return "\uFB58";

                //ت
                case 1578:
                    return "\uFE97";

                //ث
                case 1579:
                    return "\uFE9B";

                //ج
                case 1580:
                    return "\uFE9F";

                //چ
                case 1670:
                    return "\uFB7C";

                //ح
                case 1581:
                    return "\uFEA3";

                //خ
                case 1582:
                    return "\uFEA7";

                //د
                case 1583:
                    return "\uFEA9";

                //ذ
                case 1584:
                    return "\uFEAB";

                //ر
                case 1585:
                    return "\uFEAD";

                //ز
                case 1586:
                    return "\uFEAF";

                //ژ
                case 1688:
                    return "\uFB8A";

                //س
                case 1587:
                    return "\uFEB3";

                //ش
                case 1588:
                    return "\uFEB7";

                //ص
                case 1589:
                    return "\uFEBB";

                //ض
                case 1590:
                    return "\uFEBF";

                //ط
                case 1591:
                    return "\uFEC3";

                //ظ
                case 1592:
                    return "\uFEC5";

                //ع
                case 1593:
                    return "\uFECB";

                //غ
                case 1594:
                    return "\uFECF";

                //ف
                case 1601:
                    return "\uFED3";

                //ق
                case 1602:
                    return "\uFED7";

                //ک
                case 1705:
                    return "\uFEDB";

                //گ
                case 1711:
                    return "\uFB94";

                //ل
                case 1604:
                    return "\uFEDF";

                //م
                case 1605:
                    return "\uFEE3";

                //ن
                case 1606:
                    return "\uFEE7";

                //و
                case 1608:
                    return "\uFEED";

                //ه
                case 1607:
                    return "\uFEEB";

                //ی
                case 1740:
                    return "\uFEF3";

                default:
                    return ((char)charCode).ToString();
            }
        }

        static string GetUnicodeMiddle(int charCode)
        {
            switch (charCode)
            {
                //الف
                case 1575:
                    return "\uFE8E";

                //ب
                case 1576:
                    return "\uFE92";

                //پ
                case 1662:
                    return "\uFB59";

                //ت
                case 1578:
                    return "\uFE98";

                //ث
                case 1579:
                    return "\uFE9C";

                //ج
                case 1580:
                    return "\uFEA0";

                //چ
                case 1670:
                    return "\uFB7D";

                //ح
                case 1581:
                    return "\uFEA4";

                //خ
                case 1582:
                    return "\uFEA8";

                //د
                case 1583:
                    return "\uFEA9";

                //ذ
                case 1584:
                    return "\uFEAB";

                //ر
                case 1585:
                    return "\uFEAD";

                //ز
                case 1586:
                    return "\uFEAF";

                //ژ
                case 1688:
                    return "\uFB8A";

                //س
                case 1587:
                    return "\uFEB4";

                //ش
                case 1588:
                    return "\uFEB8";

                //ص
                case 1589:
                    return "\uFEBC";

                //ض
                case 1590:
                    return "\uFEC0";

                //ط
                case 1591:
                    return "\uFEC2";

                //ظ
                case 1592:
                    return "\uFEC8";

                //ع
                case 1593:
                    return "\uFECC";

                //غ
                case 1594:
                    return "\uFED0";

                //ف
                case 1601:
                    return "\uFED4";

                //ق
                case 1602:
                    return "\uFED8";

                //ک
                case 1705:
                    return "\uFEDC";

                //گ
                case 1711:
                    return "\uFB95";

                //ل
                case 1604:
                    return "\uFEE0";

                //م
                case 1605:
                    return "\uFEE4";

                //ن
                case 1606:
                    return "\uFEE8";

                //و
                case 1608:
                    return "\uFEEE";

                //ه
                case 1607:
                    return "\uFEEC";

                //ی
                case 1740:
                    return "\uFEF4";

                default:
                    return ((char)charCode).ToString();
            }
        }

        static string GetUnicodeLast(int charCode)
        {
            switch (charCode)
            {
                //الف
                case 1575:
                    return "\uFE8E";

                //ب
                case 1576:
                    return "\uFE8F";

                //پ
                case 1662:
                    return "\uFB56";

                //ت
                case 1578:
                    return "\uFE95";

                //ث
                case 1579:
                    return "\uFE99";

                //ج
                case 1580:
                    return "\uFE9D";

                //چ
                case 1670:
                    return "\uFB7A";

                //ح
                case 1581:
                    return "\uFEA1";

                //خ
                case 1582:
                    return "\uFEA5";

                //د
                case 1583:
                    return "\uFEA9";

                //ذ
                case 1584:
                    return "\uFEAB";

                //ر
                case 1585:
                    return "\uFEAD";

                //ز
                case 1586:
                    return "\uFEAF";

                //ژ
                case 1688:
                    return "\uFB8A";

                //س
                case 1587:
                    return "\uFEB1";

                //ش
                case 1588:
                    return "\uFEB5";

                //ص
                case 1589:
                    return "\uFEB9";

                //ض
                case 1590:
                    return "\uFEBD";

                //ط
                case 1591:
                    return "\uFEC3";

                //ظ
                case 1592:
                    return "\uFEC5";

                //ع
                case 1593:
                    return "\uFEC9";

                //غ
                case 1594:
                    return "\uFECD";

                //ف
                case 1601:
                    return "\uFED1";

                //ق
                case 1602:
                    return "\uFED5";

                //ک
                case 1705:
                    return "\uFED9";

                //گ
                case 1711:
                    return "\uFB92";

                //ل
                case 1604:
                    return "\uFEDD";

                //م
                case 1605:
                    return "\uFEE1";

                //ن
                case 1606:
                    return "\uFEE5";

                //و
                case 1608:
                    return "\uFEED";

                //ه
                case 1607:
                    return "\uFEE9";

                //ی
                case 1740:
                    return "\uFEEF";

                default:
                    return ((char)charCode).ToString();
            }
        }

        static string Reverse(string text)
        {
            if (text == null)
            {
                return null;
            }
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

    }
}
