var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "OK"
    });
});

app.MapGet("/tasks", () =>
{
    var tasks = new[]
    {
        new { id = 1, title = "Изучить Docker", completed = true },
        new { id = 2, title = "Создать Dockerfile", completed = false },
        new { id = 3, title = "Запустить контейнер", completed = false }
    };

    return Results.Ok(tasks);
});

app.Run();