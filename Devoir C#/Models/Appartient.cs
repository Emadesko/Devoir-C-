namespace Devoir.Models;

public class Appartient
{
    public int Id { get; set; }
    public string Matricule { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public virtual ICollection<Absence>? Absences { get; set; }
    public virtual ICollection<Classe>? Classes { get; set; }

}