namespace Devoir.Models;

public class Module{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public virtual ICollection<Cours>? Cours { get; set; }

}