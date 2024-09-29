
class Program
{
    public static void Main()
    {
        Console.WriteLine("Matn taxrir qiluvchi dasturiga xush kelibsiz!");

        while (true)
        {
            ShowMenu();
            Console.Write("Tanlang: ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    FormatText();
                    break;
                case "2":
                    SplitText();
                    break;
                case "3":
                    SubstringText();
                    break;
                case "4":
                    CompareTexts();
                    break;
                case "5":
                    ReplaceText();
                    break;
                case "6":
                    ContainsWord();
                    break;
                case "7":
                    JoinTexts();
                    break;
                case "8":
                    TrimText();
                    break;
                case "9":
                    EndsWithText();
                    break;
                case "10":
                    IndexOfChar();
                    break;
                case "11":
                    RemoveFromText();
                    break;
                case "12":
                    ToUpperText();
                    break;
                case "13":
                    ToLowerText();
                    break;
                case "14":
                    PadLeftText();
                    break;
                case "15":
                    PadRightText();
                    break;
                case "16":
                    StartsWithText();
                    break;
                case "17":
                    ToCharArrayText();
                    break;
                case "18":
                    LastIndexOfChar();
                    break;
                case "19":
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, qaytadan urinib ko'ring.");
                    break;
            }

            Console.WriteLine("\nDavom etish uchun Enter tugmasini bosing...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    private static void LastIndexOfChar()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        Console.WriteLine("Qaysi belgining oxirgi indeksini topmoqchisiz?");
        char searchChar = Console.ReadLine()![0];

        int lastIndex = inputText.LastIndexOf(searchChar);

        if (lastIndex != -1)
        {
            Console.WriteLine($"Belgining oxirgi uchrashgan joyi: {lastIndex}");
        }
        else
        {
            Console.WriteLine($"'{searchChar}' belgisi matnda topilmadi.");
        }
    }

    private static void ToCharArrayText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        char[] charArray = inputText.ToCharArray();

        Console.WriteLine("Matnni harflarga ajratish: ['" + string.Join("', '", charArray) + "']");
    }

    private static void StartsWithText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        Console.WriteLine("Matn qaysi so'z bilan boshlanishini tekshirishni xohlaysiz?");
        string startWord = Console.ReadLine()!;

        bool startsWithWord = inputText.StartsWith(startWord, StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Matn \"{startWord}\" bilan boshlanadimi? {(startsWithWord ? "Ha" : "Yo'q")}");
    }

    private static void PadRightText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        Console.WriteLine("Matnni qancha bo'sh joy bilan o'ng tomondan to'ldirishni xohlaysiz?");
        int paddingLength = int.Parse(Console.ReadLine()!);

        string paddedText = inputText.PadRight(inputText.Length + paddingLength);
        Console.WriteLine("Natija: '" + paddedText + "'");
    }

    private static void PadLeftText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        Console.WriteLine("Matnni qancha bo'sh joy bilan chap tomondan to'ldirishni xohlaysiz?");
        int paddingLength = int.Parse(Console.ReadLine()!);

        string paddedText = inputText.PadLeft(inputText.Length + paddingLength);
        Console.WriteLine("Natija: '" + paddedText + "'");
    }

    private static void ToLowerText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        string lowerText = inputText.ToLower();
        Console.WriteLine("Harflarni kichik qilingan holati: " + lowerText);
    }

    private static void ToUpperText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        string upperText = inputText.ToUpper();
        Console.WriteLine("Harflarni katta qilingan holati: " + upperText);
    }

    private static void RemoveFromText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        Console.WriteLine("Qaysi indeksdan boshlab olib tashlashni xohlaysiz?");
        int startIndex = int.Parse(Console.ReadLine()!);

        string removedText = inputText.Remove(startIndex);

        Console.WriteLine("Matnni olib tashlanganidan keyingi holati: " + removedText);
    }

    private static void IndexOfChar()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Qaysi belgi indeksini aniqlashni xohlaysiz?");
        char charToFind = Console.ReadLine()![0];

        int index = inputText.IndexOf(charToFind);

        Console.WriteLine("Belgi indeksi: " + index);
    }

    private static void EndsWithText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Matn qaysi so'z bilan tugayotganini tekshirishni xohlaysiz?");
        string suffixToCheck = Console.ReadLine()!;

        bool endsWithSuffix = inputText.EndsWith(suffixToCheck);

        Console.WriteLine($"Matn \"{suffixToCheck}\" bilan tugaydimi? {(endsWithSuffix ? "Ha" : "Yo'q")}");
    }

    private static void TrimText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;

        string trimmedText = inputText.Trim();

        Console.WriteLine("Trim qilingan matn: \"" + trimmedText + "\"");
    }

    private static void JoinTexts()
    {
        Console.WriteLine("Qaysi matnlarni birlashtirishni xohlaysiz?");
        
        string[] texts = new string[3];
        for (int i = 0; i < 3; i++)
        {
            texts[i] = Console.ReadLine()!;
        }

        Console.WriteLine("Matnlarni qaysi belgi bilan ajratishni xohlaysiz?");
        string separator = Console.ReadLine()!;

        string joinedText = string.Join(separator, texts);

        Console.WriteLine("Birlashtirilgan matn: " + joinedText);
    }

    private static void ContainsWord()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Matn ichida qaysi so'zni tekshirishni xohlaysiz?");
        string wordToCheck = Console.ReadLine()!;

        bool containsWord = inputText.Contains(wordToCheck);

        Console.WriteLine($"Matn \"{wordToCheck}\"ni o'z ichiga oladimi? {(containsWord ? "Ha" : "Yo'q")}");
    }

    private static void ReplaceText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Qaysi so'zni almashtirishni xohlaysiz?");
        string oldWord = Console.ReadLine()!;

        Console.WriteLine("Qaysi so'z bilan almashtirishni xohlaysiz?");
        string newWord = Console.ReadLine()!;

        string replacedText = inputText.Replace(oldWord, newWord);

        Console.WriteLine("Almashtirilgan matn: " + replacedText);
    }

    private static void CompareTexts()
    {
        Console.WriteLine("Birinchi matnni kiriting:");
        string firstText = Console.ReadLine()!;

        Console.WriteLine("Ikkinchi matnni kiriting:");
        string secondText = Console.ReadLine()!;

        int comparisonResult = string.Compare(firstText, secondText, StringComparison.Ordinal);

        Console.WriteLine("Taqqoslash natijasi: " + comparisonResult);

        if (comparisonResult < 0)
        {
            Console.WriteLine("Birinchi matn ikkinchi matndan oldin keladi.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("Ikkinchi matn birinchi matndan oldin keladi.");
        }
        else
        {
            Console.WriteLine("Ikkala matn bir xil.");
        }
    }

    private static void SubstringText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Qaysi indeksdan substring olishni xohlaysiz?");
        int startIndex;
        if (int.TryParse(Console.ReadLine(), out startIndex))
        {
            if (startIndex >= 0 && startIndex < inputText.Length)
            {
                Console.WriteLine("Nechta element substring qilib olishni xohlaysiz?");
                int length;
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    if (length > 0 && startIndex + length <= inputText.Length)
                    {
                        string substring = inputText.Substring(startIndex, length);
                        Console.WriteLine("Substring: " + substring);
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri uzunlik kiritildi. Uzunlik musbat bo'lishi va matn chegarasidan chiqmasligi kerak.");
                    }
                }
                else
                {
                    Console.WriteLine("Noto'g'ri uzunlik kiritildi. Iltimos, son kiriting.");
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri indeks kiritildi. Indeks 0 dan " + (inputText.Length - 1) + " gacha bo'lishi kerak.");
            }
        }
        else
        {
            Console.WriteLine("Noto'g'ri indeks kiritildi. Iltimos, son kiriting.");
        }
    }

    private static void SplitText()
    {
        Console.WriteLine("Matn kiriting:");
        string inputText = Console.ReadLine()!;
        Console.WriteLine("Matnni qaysi belgi bo'yicha ajratmoqchisiz?");
        char separator = Console.ReadLine()![0];

        string[] parts = inputText.Split(separator);

        Console.WriteLine("Bo'laklar:");
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }

    private static void FormatText()
    {
        Console.WriteLine("Ismni kiriting:");
        string firstName = Console.ReadLine()!;

        Console.WriteLine("Familiyani kiriting:");
        string lastName = Console.ReadLine()!;

        string formattedText = string.Format("Salom, {0} {1}!", firstName, lastName);

        Console.WriteLine("Formatlangan matn: " + formattedText);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("Tanlang:");
        Console.WriteLine("1. Matnni formatlash (Format)");
        Console.WriteLine("2. Matnni bo'laklarga ajratish (Split)");
        Console.WriteLine("3. Matndan substring olish (Substring)");
        Console.WriteLine("4. Matnlarni taqqoslash (Compare)");
        Console.WriteLine("5. Matnni almashtirish (Replace)");
        Console.WriteLine("6. Matn ichida so'z topish (Contains)");
        Console.WriteLine("7. Matnlarni birlashtirish (Join)");
        Console.WriteLine("8. Bo'sh joylarni olib tashlash (Trim)");
        Console.WriteLine("9. Matn oxirini tekshirish (EndsWith)");
        Console.WriteLine("10. Belgining indeksini aniqlash (IndexOf)");
        Console.WriteLine("11. Matnni o'chirish (Remove)");
        Console.WriteLine("12. Harflarni katta qilish (ToUpper)");
        Console.WriteLine("13. Harflarni kichik qilish (ToLower)");
        Console.WriteLine("14. Matnni chap tomondan to'ldirish (PadLeft)");
        Console.WriteLine("15. Matnni o'ng tomondan to'ldirish (PadRight)");
        Console.WriteLine("16. Matn boshini tekshirish (StartsWith)");
        Console.WriteLine("17. Matnni harflarga ajratish (ToCharArray)");
        Console.WriteLine("18. Oxirgi uchraydigan indeksni aniqlash (LastIndexOf)");
        Console.WriteLine("19. Chiqish");
    }
}