﻿namespace TrackerLibrary.Models;

public class MatchupEntryModel
{
    /// <summary>
    /// Represents one team in the matchup.
    /// </summary>
    public TeamModel TeamCompeting { get; set; } = null!;

    /// <summary>
    /// Represents the score for this particular team.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Represents the matchup that this team came from as a winner.
    /// </summary>
    public MatchupModel ParentMatchup { get; set; } = null!;
}