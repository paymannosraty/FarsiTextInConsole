namespace TestFarsi.Infrastructure
{
    static internal class ChangeFarsiToUnicode
    {
        static ChangeFarsiToUnicode()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            //د
            SeparateCharacterList.Add(1583);
            //ذ
            SeparateCharacterList.Add(1584);
            //ر
            SeparateCharacterList.Add(1585);
            //ز
            SeparateCharacterList.Add(1586);
            //ژ
            SeparateCharacterList.Add(1668);
            //و
            SeparateCharacterList.Add(1608);
        }

        readonly static List<int> SeparateCharacterList = new List<int>();

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

                        if (index == 0 || (index != input.Length - 1 &&
                            SeparateCharacterList.Any(current => current == input[index - 1]) &&
                            input[index + 1] != 32))
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
            return charCode switch
            {
                //الف
                1575 => "\uFE8D",
                //ب
                1576 => "\uFE91",
                //پ
                1662 => "\uFB58",
                //ت
                1578 => "\uFE97",
                //ث
                1579 => "\uFE9B",
                //ج
                1580 => "\uFE9F",
                //چ
                1670 => "\uFB7C",
                //ح
                1581 => "\uFEA3",
                //خ
                1582 => "\uFEA7",
                //د
                1583 => "\uFEA9",
                //ذ
                1584 => "\uFEAB",
                //ر
                1585 => "\uFEAD",
                //ز
                1586 => "\uFEAF",
                //ژ
                1688 => "\uFB8A",
                //س
                1587 => "\uFEB3",
                //ش
                1588 => "\uFEB7",
                //ص
                1589 => "\uFEBB",
                //ض
                1590 => "\uFEBF",
                //ط
                1591 => "\uFEC3",
                //ظ
                1592 => "\uFEC5",
                //ع
                1593 => "\uFECB",
                //غ
                1594 => "\uFECF",
                //ف
                1601 => "\uFED3",
                //ق
                1602 => "\uFED7",
                //ک
                1705 => "\uFEDB",
                //گ
                1711 => "\uFB94",
                //ل
                1604 => "\uFEDF",
                //م
                1605 => "\uFEE3",
                //ن
                1606 => "\uFEE7",
                //و
                1608 => "\uFEED",
                //ه
                1607 => "\uFEEB",
                //ی
                1740 => "\uFEF3",
                _ => ((char)charCode).ToString(),
            };
        }

        static string GetUnicodeMiddle(int charCode)
        {
            return charCode switch
            {
                //الف
                1575 => "\uFE8E",
                //ب
                1576 => "\uFE92",
                //پ
                1662 => "\uFB59",
                //ت
                1578 => "\uFE98",
                //ث
                1579 => "\uFE9C",
                //ج
                1580 => "\uFEA0",
                //چ
                1670 => "\uFB7D",
                //ح
                1581 => "\uFEA4",
                //خ
                1582 => "\uFEA8",
                //د
                1583 => "\uFEA9",
                //ذ
                1584 => "\uFEAB",
                //ر
                1585 => "\uFEAD",
                //ز
                1586 => "\uFEAF",
                //ژ
                1688 => "\uFB8A",
                //س
                1587 => "\uFEB4",
                //ش
                1588 => "\uFEB8",
                //ص
                1589 => "\uFEBC",
                //ض
                1590 => "\uFEC0",
                //ط
                1591 => "\uFEC2",
                //ظ
                1592 => "\uFEC8",
                //ع
                1593 => "\uFECC",
                //غ
                1594 => "\uFED0",
                //ف
                1601 => "\uFED4",
                //ق
                1602 => "\uFED8",
                //ک
                1705 => "\uFEDC",
                //گ
                1711 => "\uFB95",
                //ل
                1604 => "\uFEE0",
                //م
                1605 => "\uFEE4",
                //ن
                1606 => "\uFEE8",
                //و
                1608 => "\uFEEE",
                //ه
                1607 => "\uFEEC",
                //ی
                1740 => "\uFEF4",

                _ => ((char)charCode).ToString(),
            };
        }

        static string GetUnicodeLast(int charCode)
        {
            return charCode switch
            {
                //الف
                1575 => "\uFE8D",
                //ب
                1576 => "\uFE8F",
                //پ
                1662 => "\uFB56",
                //ت
                1578 => "\uFE95",
                //ث
                1579 => "\uFE99",
                //ج
                1580 => "\uFE9D",
                //چ
                1670 => "\uFB7A",
                //ح
                1581 => "\uFEA1",
                //خ
                1582 => "\uFEA5",
                //د
                1583 => "\uFEA9",
                //ذ
                1584 => "\uFEAB",
                //ر
                1585 => "\uFEAD",
                //ز
                1586 => "\uFEAF",
                //ژ
                1688 => "\uFB8A",
                //س
                1587 => "\uFEB1",
                //ش
                1588 => "\uFEB5",
                //ص
                1589 => "\uFEB9",
                //ض
                1590 => "\uFEBD",
                //ط
                1591 => "\uFEC3",
                //ظ
                1592 => "\uFEC5",
                //ع
                1593 => "\uFEC9",
                //غ
                1594 => "\uFECD",
                //ف
                1601 => "\uFED1",
                //ق
                1602 => "\uFED5",
                //ک
                1705 => "\uFED9",
                //گ
                1711 => "\uFB92",
                //ل
                1604 => "\uFEDD",
                //م
                1605 => "\uFEE1",
                //ن
                1606 => "\uFEE5",
                //و
                1608 => "\uFEED",
                //ه
                1607 => "\uFEE9",
                //ی
                1740 => "\uFEEF",

                _ => ((char)charCode).ToString(),
            };
        }

        static string Reverse(string text)
        {
            string result = string.Empty;

            if (string.IsNullOrEmpty(text) == false)
            {
                char[] array = text.ToCharArray();
                Array.Reverse(array);
                result = new String(array);
            }
            return result;
        }
    }
}
