namespace FanBook.Models
{
  public class BandMember
  {       
    public int BandMemberId { get; set; }
    public int MemberId { get; set; }
    public int BandId { get; set; }
    public virtual Member Member { get; set; }
    public virtual Band Band { get; set; }
  }
}