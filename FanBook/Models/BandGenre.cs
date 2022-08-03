namespace FanBook.Models
{
  public class BandGenre
  {       
    public int BandGenreId { get; set; }
    public int GenreId { get; set; }
    public int BandId { get; set; }
    public virtual Genre Genre { get; set; }
    public virtual Band Band { get; set; }
  }
}