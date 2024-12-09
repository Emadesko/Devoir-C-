namespace Devoir.Models;

public class Absence{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public Etudiant Etudiant { get; set; }
    public Cours Cours { get; set; }
}