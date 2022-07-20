using Cocona;

var app = CoconaApp.Create();

app.AddCommand("init-db", () =>
{
  Console.WriteLine("db init");
}).WithDescription("Initialize the database").WithAliases("i");
app.AddCommand("kill-db", () =>
{
  Console.WriteLine("db kill");
}).WithDescription("Kill the database").WithAliases("k");


app.Run();
