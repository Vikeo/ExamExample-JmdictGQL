using JMDict;
using JmdictGQL;

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
    })
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseCors("AllowAny");

app.MapGraphQL();

app.Run();