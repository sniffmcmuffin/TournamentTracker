namespace TrackerLibrary.Models;

public class TournamentModel
{
    public string TournamentName { get; set; } = null!;
    public decimal EntryFee { get; set; }
    public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
    public List<PriceModel> Prizes { get; set; } = new List<PriceModel>();
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
}