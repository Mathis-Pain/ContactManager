// Creation d'un serveur 
var builder = WebApplication.CreateBuilder(args);
// configure les services (on ne peut pas en ajouter apres le build)
builder.Services.AddControllers(); 
// construit le serveur
var app = builder.Build();

// Permet de servir les fichiers dans wwwroot
app.UseDefaultFiles();
// Ce middleware dit :"Si quelqu’un demande /, regarde s’il y a un fichier par défaut"
app.UseStaticFiles(); 
//Va chercher les fichiers statiques dans le dossier wwwroot
// (WebRootPath = "wwwroot" ASP.NET Core configure automatiquement)
Database.Init();
// active les controlleurs pour gerer les routes
app.MapControllers();   
app.Run();
