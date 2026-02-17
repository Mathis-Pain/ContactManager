# Projet Gestionnaire de Contacts C# + JS + SQL

Fonctionnalités :

- Ajouter un contact
- Afficher la liste des contacts
- Modifier un contact
- Supprimer un contact
- Rechercher un contact

## premier pas

Cration du dossier principale et initialisation du projet

- dotnet new console : initialise le projet comme un npm init en js/node
  - dotnet new console # App qui tourne dans le terminal
  - dotnet new web # projet web minimal casi vide
  - dotnet new webapi # API REST (comme un serveur Express en JS)
  - dotnet new winforms # App avec fenêtres (Windows only)
- dotnet run : lance le programme

Console.Writeline("");
Console.ReadLine(); cree un prompt utilisateur qui renvoi une string
int.Parse converti une string en int
git checkout -- . annule toute modification non sauvegardé dans le fichier actuel
git checkout main

## creation de la bdd

- taper la commande dotnet add package Microsoft.Data.Sqlite - installe la bibliothèque pour parler avec SQLite depuis C#
- ajouter en haut du fichier c# - using Microsoft.Data.Sqlite; pour importer la bibliotheque

## separer les fichiers

public static void Init()
│ │ │ │
│ │ │ └── Le nom (tu choisis ce que tu veux)
│ │ └── Ne retourne rien
│ └── Pas besoin de créer un objet
└── Accessible depuis d'autres fichiers

- class Database
  Un conteneur pour tes fonctions BDD
- public autre choix -> private
  Accessible depuis d'autres fichiers
- static autre choix -> ""
  Pas besoin de faire new Database()
- void autre choix -> int, string, bool, double
  Ne retourne rien
- Init()
  Le nom de ta fonction

pour appeler un fichier on peu juste appeler le class.function()
pour appeler un fichier venant d'un dossier different il faut cree un namespace nomduprojet.nomdudossier et importer avec using nomduprojet.nomdudossier

## mise en place d'un serveur

‼️ on ne peut pas cree un serveur dans un projet classique qui tourne en local il faut en recree un

- Creation du serveur
  var builder = WebApplication.CreateBuilder(args);
  var app = builder.Build();
  (launchSettings.json permet de personnaliser l'adresse serveur)
