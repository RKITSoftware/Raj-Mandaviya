public static string Capitalize(this string word)
{
    if (word.Length > 0) //Word is null
    {
        char[] charArray = word.ToCharArray();
        charArray[0] = char.IsLower(charArray[0]) ?      char.ToUpper(charArray[0]) : charArray[0];
        return new string(charArray);
    }
   	return word;
}
