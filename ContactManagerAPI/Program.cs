// Creation d'un serveur 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Permet de servir les fichiers dans wwwroot
app.UseDefaultFiles();
// Ce middleware dit :"Si quelqu’un demande /, regarde s’il y a un fichier par défaut"
app.UseStaticFiles(); 
//Va chercher les fichiers statiques dans le dossier wwwroot
// (WebRootPath = "wwwroot" ASP.NET Core configure automatiquement)
Database.Init();
app.Run();
