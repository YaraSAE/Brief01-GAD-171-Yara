using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = 0;
        strength = Random.Range(1, 11);
        agility = 0;
        agility = Random.Range(1, 11);
        intelligence = 0;
        intelligence = Random.Range(1, 11);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("The current physical stats are (" + strength+ ", " + agility+ ", " + intelligence + ")");

        // let's create some float temporary variables to hold our multiplier values.

        // create an agility multiplier should be set to 0.5
        float agilityMultiplier = 0.5f;

        // create a strength multiplier should be set to 1
        float strengthMultiplier = 1f;

        // create an intelligence multiplier should be set to 2.
        float intelligenceMultiplier = 2f;

        // Debug out our current multiplier values.
        Debug.Log("Agility Multiplier: " + agilityMultiplier);
        Debug.Log("strength multiplie: " + strengthMultiplier);
        Debug.Log("intelligence multiplier: " + intelligenceMultiplier);


        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = (int)strength;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = (int)(intelligence * 1.5f);
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = (int)(agility * 0.5f);

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("The current dancing stats are (" + style+ ", " + luck+ ", " + rhythm + ")");

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        strength += additionalPoints;
        agility += additionalPoints;
        intelligence += additionalPoints;
        // Debug out our new physical stat values
        Debug.Log("The new physical stats are (" + strength+ ", " + agility+ ", " + intelligence + ")");

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        style = (int)strength;
        luck = (int)(intelligence * 1.5f);
        rhythm = (int)(agility * 0.5f);

        // Debug out our new dancing stat values
    Debug.Log("The current dancing stats are (" + style+ ", " + luck+ ", " + rhythm + ")");

    }
}
