namespace Devoir.Models;

public class Classe{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public string Filiere { get; set; }
    public virtual ICollection<Appartient>? Appartients { get; set; }
    public virtual ICollection<FaireCours>? FaireCours { get; set; }

}