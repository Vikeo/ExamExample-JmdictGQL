using JMDict;

namespace JmdictGQL
{
    public class Query
    {
        private readonly Jmdict _jmdict;

        public Query(Jmdict jmdict)
        {
            _jmdict = jmdict;
        }

        public IEnumerable<JmdictEntry?> EntriesByReading(string reading)
        {
            return _jmdict.Entry.Where(entry => entry.KanjiReading.Any(kr => kr.Reading == reading) != null);
        }
    }
}
