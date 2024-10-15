﻿namespace TrackerLibrary.Models;

/// <summary>
/// Represents one match in the tournament.
/// </summary>
public class MatchupModel
{
    /// <summary>
    /// The set of teams that were involved in this match.
    /// </summary>
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
    
    /// <summary>
    /// The winner of the match.
    /// </summary>
    public TeamModel Winner { get; set; } = null!;
    
    /// <summary>
    /// Which round this match is a part of.
    /// </summary>
    public int MatchupRound {  get; set; }
}