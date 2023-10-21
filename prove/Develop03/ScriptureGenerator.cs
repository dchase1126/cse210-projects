class ScriptureGenerator
{
    private Random random = new Random();
    private string[][] _scriptureList = new string[][]
    {
        new string[] {"John", "3:", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."},
        new string[] {"John", "13:","34-","35",  "(34) A new commandment I give unto you, That ye love one another; as I have loved you, that ye also love one another. (35) By this shall all men know that ye are my disciples, if ye have love one to another."},
        new string[] {"Proverbs", "10:","12", "Hatred stirs up conflict, but love covers over all wrongs."},
        new string[] {"John", "15:","13","Greater love has no one than this: to lay down one`s life for one`s friends."},
    };

    public string[] GetRandomScripture()
    {
        int index = random.Next(_scriptureList.Length);
        return _scriptureList[index];
    }

    public string[] GetScripture(int index)
    {
        return _scriptureList[index];
    }
}