namespace Devoir.Models;

public class Etudiant
{
    public int Id { get; set; }
    public string Matricule { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public virtual ICollection<Absence>? Absences { get; set; }
    public virtual ICollection<Appartient>? Appartients { get; set; }

}