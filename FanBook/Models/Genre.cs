using System.Collections.Generic;

namespace FanBook.Models
{
  public class Genre
  {
    public Genre()
    {
      this.JoinEntities = new HashSet<BandGenre>();
    }

    public int GenreId { get; set; }
    public string Type { get; set; }

    public virtual ICollection<BandGenre> JoinEntities { get;}
  }
}