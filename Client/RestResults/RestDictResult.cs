using System.Text.Json.Serialization;

namespace Client.RestResults
{
    public class RestDictResult
    {
        [JsonPropertyName("sequence")]
        public int Sequence { get; set; }

        [JsonPropertyName("kanji")]
        public Kanji[] Kanji { get; set; }

        [JsonPropertyName("readings")]
        public Reading[] Readings { get; set; }

        [JsonPropertyName("senseElements")]
        public SenseElement[] SenseElements { get; set; }
    }

    public class Kanji
    {
        [JsonPropertyName("expression")]
        public string Expression { get; set; }

        [JsonPropertyName("information")]
        public string[] Information { get; set; }

        [JsonPropertyName("priorities")]
        public string[] Priorities { get; set; }
    }

    public class Reading
    {
        [JsonPropertyName("kana")]
        public string Kana { get; set; }

        [JsonPropertyName("noKanji")]
        public string NoKanji { get; set; }

        [JsonPropertyName("restrictions")]
        public object[] Restrictions { get; set; }

        [JsonPropertyName("information")]
        public object[] Information { get; set; }

        [JsonPropertyName("priorities")]
        public string[] Priorities { get; set; }
    }

    public class SenseElement
    {
        [JsonPropertyName("restrictedKanji")]
        public object[] RestrictedKanji { get; set; }

        [JsonPropertyName("restrictedReadings")]
        public object[] RestrictedReadings { get; set; }

        [JsonPropertyName("references")]
        public object[] References { get; set; }

        [JsonPropertyName("antonyms")]
        public object[] Antonyms { get; set; }

        [JsonPropertyName("partsOfSpeech")]
        public string[] PartsOfSpeech { get; set; }

        [JsonPropertyName("fields")]
        public object[] Fields { get; set; }

        [JsonPropertyName("misc")]
        public string[] Misc { get; set; }

        [JsonPropertyName("sourceLanguages")]
        public object[] SourceLanguages { get; set; }

        [JsonPropertyName("dialects")]
        public object[] Dialects { get; set; }

        [JsonPropertyName("information")]
        public string[] Information { get; set; }

        [JsonPropertyName("glossary")]
        public Glossary[] Glossary { get; set; }

        [JsonPropertyName("examples")]
        public object[] Examples { get; set; }
    }

    public class Glossary
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("language")]
        public object Language { get; set; }

        [JsonPropertyName("gender")]
        public object Gender { get; set; }

        [JsonPropertyName("type")]
        public object Type { get; set; }
    }
}