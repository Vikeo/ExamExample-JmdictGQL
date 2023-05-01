# JmdictGQL

This is a simple example of a .NET 7 ASP.NET Core GraphQL server and Blazor WASM application with a GraphQL client.

## Prerequisites:

- Visual Studio 2022

If you don't have Visual Studio 2022, you can install it from here: [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)

- .NET 7 SDK

If you don't have the .NET 7 SDK, you can install it from here: [.Net 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

- `Jmdict_e.xml` dictionary file

Jmdict dictionary file is not provided, but it is required for the server to be able to run. You can download the latest `JMdict_e.gz` file from here: [Link](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project#CURRENT_VERSION_&_DOWNLOAD)

After downloading the file, extract it and place the `JMdict_e.xml` file in a `dictionaries` folder inside the `Server` directory. The resulting filepath should be as follows: `Server/dictionaries/JMdict_e.xml`.

## How to run

### Using a terminal, like `cmd` or `powershell`, go into the `Server` directory and run `dotnet run`

- Go into the server directory and run `dotnet run`

### Using Visual Studio 2022

- Open the `JmdictGQL.sln` solution file.
- In the solution Explorer, right click at the top of the solution and select `Set Startup Projects...` from the context menu. In the window that opens, select `Multiple startup projects` and set the `Action` for both `Server` and `Client` to `Start`. Click `OK`.
- Press `F5` or press the `Start` button to run the solution.
- This will open the Client in a browser window and the Banana Cake Pop GraphQL IDE in another browser window.

How to update the schema in the client:

- Go into the server directory and run `dotnet run`
- Go into the client directory and run `dotnet graphql update`

If the `schema.graphql` doesn't update, run `dotnet graphql download http://localhost:5051/graphql/` update it.

The client will now have the latest schema, but now we need to update the queries:

- Run `dotnet clean`, which has been configured to delete the `obj` folder, followed by `dotnet build`.

TODO:

[ ] Don't overfetch data.
