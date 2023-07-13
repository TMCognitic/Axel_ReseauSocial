// See https://aka.ms/new-console-template for more information
using Axel_ReseauSocial.Api.Domains;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using System.Text.Json;

using ReseauSocialDbContext dbContext = new ReseauSocialDbContext();

#region Ajout des Localites
//using TextReader textReader = File.OpenText(@"c:\Data\code-postaux-belge.csv");

////Eliminer la ligne titre
//textReader.ReadLine();

//string? values;
//while ((values = textReader.ReadLine()) is not null)
//{
//    string[] infos = values.Split(';');
//    Localite localite = new Localite()
//    {
//        CP = int.Parse(infos[0]),
//        Ville = infos[1],
//        Longitude = double.Parse(infos[2], CultureInfo.InvariantCulture),
//        Latitude = double.Parse(infos[3], CultureInfo.InvariantCulture)
//    };

//    dbContext.Localites.Add(localite);
//}
#endregion

#region AddAdmin
//Role userRole = dbContext.Roles.First(r => r.Denomination == "Admin");
//Localite userLocalite = dbContext.Localites.First(l => l.Ville == "Jumet");

//Utilisateur utilisateur = new Utilisateur()
//{
//    Nom = "Bauduin",
//    Prenom = "Axel",
//    Email = "axel.bauduin@gmail.com",
//    Passwd = "Test1234=",
//    Localite = userLocalite,
//    Role = userRole
//};

//dbContext.Add(utilisateur);
#endregion



//Utilisateur? u = dbContext.Utilisateurs.Find(new Guid("9b4d3e6f-7921-ee11-88c7-c8cb9e5dcba3"));

//using TextWriter textWriter = File.CreateText("out.json");
//textWriter.WriteLine(JsonSerializer.Serialize(u));

using TextReader textWriter = File.OpenText("out.json");
Utilisateur? utilisateur = JsonSerializer.Deserialize<Utilisateur>(textWriter.ReadLine());
utilisateur.Passwd = "Test1235=";

dbContext.Attach(utilisateur);
dbContext.Entry(utilisateur).State = EntityState.Modified;

dbContext.SaveChanges();
dbContext.ChangeTracker.Clear();


Console.WriteLine();