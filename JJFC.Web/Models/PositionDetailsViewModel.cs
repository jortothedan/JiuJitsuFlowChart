namespace JJFC.Web.Models;

public class PositionDetailsViewModel
{
    public string Description { get; set; }
    public string YoutubeVideoId { get; set; }
    public List<string> ProsList { get; set; } = new();
    public List<string> ConsList { get; set; } = new();
    public List<string> PossibleAttacks { get; set; } = new();
    public List<string> PossibleEscapes { get; set; } = new();
    public List<string> Transitions { get; set; } = new();

    public PositionDetailsViewModel()
    {
    }
}