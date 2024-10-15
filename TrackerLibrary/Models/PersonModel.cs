namespace TrackerLibrary.Models;

/// <summary>
/// Represents one person.
/// </summary>
public class PersonModel
{
    /// <summary>
    /// The first name of the person.
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// The last name of the person.
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// The primary email address of the person.
    /// </summary>
    public string EmailAddress { get; set; } = null!;

    /// <summary>
    /// The primary cell phone number of the person.
    /// </summary>
    public string CellphoneNumber { get; set; } = null!;
}