namespace Client.RestResults;

public class KaraokeResult
{
    public int Sequence { get; set; }
    public List<Kanji> Kanji { get; set; }
    public List<Reading> Readings { get; set; }
    public List<SenseElement> SenseElements { get; set; }
}

public class Kanji
{
    public string Expression { get; set; }
    public List<string> Information { get; set; }
    public List<object> Priorities { get; set; }
}

public class Reading
{
    public string Kana { get; set; }
    public object NoKanji { get; set; }
    public List<object> Restrictions { get; set; }
    public List<object> Information { get; set; }
    public List<string> Priorities { get; set; }
}

public class SenseElement
{
    public List<object> RestrictedKanji { get; set; }
    public List<object> RestrictedReadings { get; set; }
    public List<object> References { get; set; }
    public List<object> Antonyms { get; set; }
    public List<string> PartsOfSpeech { get; set; }
    public List<object> Fields { get; set; }
    public List<string> Misc { get; set; }
    public List<object> SourceLanguages { get; set; }
    public List<object> Dialects { get; set; }
    public List<string> Information { get; set; }
    public List<Glossary> Glossary { get; set; }
    public List<object> Examples { get; set; }
}

public class Glossary
{
    public string Content { get; set; }
    public object Language { get; set; }
    public object Gender { get; set; }
    public object Type { get; set; }
}