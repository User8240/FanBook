using System.Collections.Generic;

namespace FanBook.Models
{
  public class Band
  {
    public Band()
    {
      this.JoinEntities = new HashSet<BandGenre>();
      this.JoinEntities2 = new HashSet<BandMember>();
    }

    public int BandId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BandGenre> JoinEntities { get; set; }
    public virtual ICollection<BandMember> JoinEntities2 { get; set; }
  }
}