using System.Collections.Generic;
using System;

namespace FanBook.Models
{
  public class Member
  {
    public Member()
    {
      this.JoinEntities = new HashSet<BandMember>();
    }

    public int MemberId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BandMember> JoinEntities { get; set; }
  }
}