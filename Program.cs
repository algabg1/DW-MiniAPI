using Microsoft.EntityFrameworkCore;
using MinimalAPI;
using MinimalAPI.model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




//INICIO COMENTARIO API
var comentarioItems = app.MapGroup("/comentarios");

comentarioItems.MapGet("/", async (TodoDb db) =>
    await db.comentarios.ToListAsync());

comentarioItems.MapGet("/{id}", async (int id, TodoDb db) =>
    await db.comentarios.FindAsync(id)
        is Comentario comentario
            ? Results.Ok(comentario)
            : Results.NotFound());

comentarioItems.MapPost("/", async (Comentario comentario, TodoDb db) =>
{
    db.comentarios.Add(comentario);
    await db.SaveChangesAsync();

    return Results.Created($"/comentarios/{comentario.id}", comentario);
});

comentarioItems.MapPut("/{id}", async (int id, Comentario inputComentario, TodoDb db) =>
{
    var comentario = await db.comentarios.FindAsync(id);

    if (comentario is null) return Results.NotFound();

    comentario.publicador = inputComentario.publicador;
    comentario.noticia = inputComentario.noticia;
    comentario.conteudo = inputComentario.conteudo;



    await db.SaveChangesAsync();

    return Results.NoContent();
});

comentarioItems.MapDelete("/{id}", async (int id, TodoDb db) =>
{
    if (await db.comentarios.FindAsync(id) is Comentario comentario)
    {
        db.comentarios.Remove(comentario);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});
//Fim COMENTARIO API





//INICIO PLANTA API
var plantaItems = app.MapGroup("/plantas");

plantaItems.MapGet("/", async (TodoDb db) =>
    await db.plantas.ToListAsync());

plantaItems.MapGet("/{id}", async (int id, TodoDb db) =>
    await db.plantas.FindAsync(id)
        is Planta planta
            ? Results.Ok(planta)
            : Results.NotFound());

plantaItems.MapPost("/", async (Planta planta, TodoDb db) =>
{
    db.plantas.Add(planta);
    await db.SaveChangesAsync();

    return Results.Created($"/projetos/{planta.id}", planta);
});

plantaItems.MapPut("/{id}", async (int id, Planta inputPlanta, TodoDb db) =>
{
    var planta = await db.plantas.FindAsync(id);

    if (planta is null) return Results.NotFound();
    
    planta.nome = inputPlanta.nome;
    planta.nomeCientifico = inputPlanta.nomeCientifico;
    planta.categoria = inputPlanta.categoria;
    planta.cuidados = inputPlanta.cuidados;
    planta.descricao = inputPlanta.descricao;
    planta.imagem = inputPlanta.imagem;
    planta.origem = inputPlanta.origem;
    planta.dataRegistro = inputPlanta.dataRegistro;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

plantaItems.MapDelete("/{id}", async (int id, TodoDb db) =>
{
    if (await db.plantas.FindAsync(id) is Planta planta)
    {
        db.plantas.Remove(planta);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});
//Fim PLANTA API







//INICIO PROJETO API
var projetoItems = app.MapGroup("/projetos");

projetoItems.MapGet("/", async (TodoDb db) =>
    await db.projetos.ToListAsync());

projetoItems.MapGet("/{id}", async (int id, TodoDb db) =>
    await db.projetos.FindAsync(id)
        is Projeto projeto
            ? Results.Ok(projeto)
            : Results.NotFound());

projetoItems.MapPost("/", async (Projeto projeto, TodoDb db) =>
{
    db.projetos.Add(projeto);
    await db.SaveChangesAsync();

    return Results.Created($"/projetos/{projeto.id}", projeto);
});

projetoItems.MapPut("/{id}", async (int id, Projeto inputProjeto, TodoDb db) =>
{
    var projeto = await db.projetos.FindAsync(id);

    if (projeto is null) return Results.NotFound();

    projeto.responsavel = inputProjeto.responsavel;
    projeto.tipoProjeto = inputProjeto.tipoProjeto;
    projeto.descricao = inputProjeto.descricao;
    projeto.nome = inputProjeto.nome;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

projetoItems.MapDelete("/{id}", async (int id, TodoDb db) =>
{
    if (await db.projetos.FindAsync(id) is Projeto projeto)
    {
        db.projetos.Remove(projeto);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});
//Fim PROJETO API





//INICIO NOTICIA API
var noticiaItems = app.MapGroup("/noticias");

noticiaItems.MapGet("/", async (TodoDb db) =>
    await db.noticias.ToListAsync());

noticiaItems.MapGet("/{id}", async (int id, TodoDb db) =>
    await db.noticias.FindAsync(id)
        is Noticia noticia
            ? Results.Ok(noticia)
            : Results.NotFound());

noticiaItems.MapPost("/", async (Noticia noticia, TodoDb db) =>
{
    db.noticias.Add(noticia);
    await db.SaveChangesAsync();

    return Results.Created($"/noticias/{noticia.id}", noticia);
});

noticiaItems.MapPut("/{id}", async (int id, Noticia inputNoticia, TodoDb db) =>
{
    var noticia = await db.noticias.FindAsync(id);

    if (noticia is null) return Results.NotFound();

    noticia.titulo = inputNoticia.titulo;
    noticia.autor = inputNoticia.autor;
    noticia.conteudo = inputNoticia.conteudo;
    noticia.comentarios = inputNoticia.comentarios;
    noticia.data = inputNoticia.data;
    noticia.imagem = inputNoticia.imagem;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

noticiaItems.MapDelete("/{id}", async (int id, TodoDb db) =>
{
    if (await db.usuarios.FindAsync(id) is Usuario user)
    {
        db.usuarios.Remove(user);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});
//Fim NOTICIA API


//INICIO USUARIO API
var userItems = app.MapGroup("/usuarios");

userItems.MapGet("/", async (TodoDb db) =>
    await db.usuarios.ToListAsync());

userItems.MapGet("/{id}", async (int id, TodoDb db) =>
    await db.usuarios.FindAsync(id)
        is Usuario user
            ? Results.Ok(user)
            : Results.NotFound());

userItems.MapPost("/", async (Usuario user, TodoDb db) =>
{
    db.usuarios.Add(user);
    await db.SaveChangesAsync();

    return Results.Created($"/usuarios/{user.id}", user);
});

userItems.MapPut("/{id}", async (int id, Usuario inputUser, TodoDb db) =>
{
    var user = await db.usuarios.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.name = inputUser.name;
    user.email = inputUser.email;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

userItems.MapDelete("/{id}", async (int id, TodoDb db) =>
{
    if (await db.usuarios.FindAsync(id) is Usuario user)
    {
        db.usuarios.Remove(user);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});
//Fim USUARIO API


app.Run();