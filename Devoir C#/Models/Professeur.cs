namespace Devoir.Models;

public class Professeur
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Specialite { get; set; }
    public string Grade { get; set; }
    public virtual ICollection<Cours>? Cours { get; set; }

}