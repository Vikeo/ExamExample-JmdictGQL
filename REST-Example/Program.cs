using JMDict;

var jmdictPath = "dictionaries/JMdict_e.xml";

var dictParser = new DictParser();

var jmdict = dictParser.ParseXml<Jmdict>(jmdictPath);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(jmdict);

var app = builder.Build();

//http://localhost:5207/reading/カラオケ
app.MapGet("/reading/{reading}", (string reading) =>
    {
        //TODO Get entries from the services jmdict instead
        var entry = jmdict.Entries
        .Where(e => e.Readings?
        .FirstOrDefault(r => r.Kana == reading) != null);

        return entry;
    });

app.Run();
