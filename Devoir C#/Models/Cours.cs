namespace Devoir.Models;

public class Cours{
    public int Id { get; set;}
    public DateOnly Data { get; set; }
    public TimeOnly HeureDebut { get; set; }
    public TimeOnly HeureFin { get; set;}
    public int NombreHeure { get; set;}
    public int Semestre { get; set;}
    public Module Module { get; set;}
}