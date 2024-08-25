namespace TrackerLibrary.Models;

public class MatchupModel
{
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
    public TeamModel Winner { get; set; } = null!;
    public int MatchupRound {  get; set; }
}