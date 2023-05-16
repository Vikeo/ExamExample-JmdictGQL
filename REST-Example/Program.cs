using JMDict;

var jmdictPath = "dictionaries/JMdict_e.xml";

var dictParser = new DictParser();

var jmdict = dictParser.ParseXml<Jmdict>(jmdictPath);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(jmdict);

builder.Services
    .AddCors(options =>
    {
        options.AddPolicy("AllowAny", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
    });

var app = builder.Build();

app.UseCors("AllowAny");

// http://localhost:5207/reading/カラオケ
app.MapGet("/reading/{reading}", (string reading, Jmdict jmdict) =>
{
    var entry = jmdict.Entries
        .Where(e => e.Readings?
        .FirstOrDefault(r => r.Kana == reading) != null);

    return entry;
});

app.Run();
