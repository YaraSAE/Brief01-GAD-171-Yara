using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = 0;
        playerOneStyle = Random.Range(1, 11);
        // luck should be random between 0-4
        int playerOneLuck = 0;
        playerOneLuck = Random.Range(0, 4);
        // ryhtm should be random between 1-6
        int playerOneRyhtm = 0;
        playerOneRyhtm= Random.Range(1, 7);
        // style should be random between 1-10
        int playerTwoStyle = 0;
        playerTwoStyle= Random.Range(1, 11);
        // luck should be random between 0-4
        int playerTwoLuck = 0;
        playerTwoLuck= Random.Range(0, 5);
        // ryhtm should be random between 1-6
        int playerTwoRyhtm = 0;
        playerTwoRyhtm= Random.Range(1, 7);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = 0;
        playerOnePowerLevel = playerOneStyle + playerOneStyle + playerOneRyhtm;
        int playerTwoPowerLevel = 0;
        playerTwoStyle = playerTwoStyle + playerTwoLuck + playerTwoRyhtm;

        // Debug out the two players, power levels.
        Debug.Log("The power level of player one is " + playerOnePowerLevel);
        Debug.Log("The power level of player two is " + playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = 0;
        int playerOneChanceToWin = ((playerOnePowerLevel + playerTwoPowerLevel) / playerOnePowerLevel) * 100;
        int playerTwoChanceToWin = (1 + (playerOnePowerLevel / playerTwoPowerLevel)) * 100;

        // Debug out the chance of each character to win.
         Debug.Log("The chance of the first player to win is " + playerOnePowerLevel);
         Debug.Log("The chance of the second player to win is " + playerTwoPowerLevel);
        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  

            // Debug out which character has won, which has lost, or if it's a draw. 
            // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
        if(playerOnePowerLevel > playerTwoPowerLevel) {
            Debug.Log("Player one has won and should win " +(playerOneChanceToWin - playerTwoChanceToWin) + "amount of experience");
            Debug.Log("Player two has lost");
        }
        else if(playerTwoPowerLevel > playerOnePowerLevel) {
            Debug.Log("Player one has won and should win " +(playerTwoChanceToWin - playerOneChanceToWin) + "amount of experience");
            Debug.Log("Player one has lost");
        }
        else{
            int defaultAmount = 5;
            Debug.Log("It is a draw");
            Debug.Log("They should win " + defaultAmount + "amount of experience");
        }
    }
}
