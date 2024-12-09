namespace Devoir.Models;

public class Appartient
{
    public int Id { get; set; }
    public DateOnly Annee { get; set; }
    public Etudiant Etudiant { get; set;}
    public Classe Classe { get; set;}
}