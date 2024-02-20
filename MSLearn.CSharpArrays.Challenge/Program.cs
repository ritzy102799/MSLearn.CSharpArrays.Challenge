string[] fraudalentIDsFrance = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (var item in fraudalentIDsFrance)
{
    //Console.WriteLine(item);
    if (item.StartsWith("A"))
    {
        Console.WriteLine(item);
    }
}
foreach (var item in fraudalentIDsFrance)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
foreach (var item in fraudalentIDsFrance)
{
    if (item.StartsWith("C"))
    {
        Console.WriteLine(item);
    }
}
foreach (var item in fraudalentIDsFrance)
{
    if (item.StartsWith("G"))
    {
        Console.WriteLine (item);
    }
}




