# JmdictGQL

Dictionary files not provided.

How to update the schema in the client:

- Go into the server directory and run `dotnet run`
- Go into the client directory and run `dotnet graphql update`

If the `schema.graphql` doesn't update, run `dotnet graphql download http://localhost:5051/graphql/` update it.

The client will now have the latest schema, but now we need to update the queries:

- Run `dotnet clean`, which has been configured to delete the `obj` folder, followed by `dotnet build`.

TODO:

[ ] Don't overfetch data.
