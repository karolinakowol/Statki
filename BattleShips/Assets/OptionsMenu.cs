using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void ChoosePlayingMode(bool isPlayerChecked)
    {
        if (isPlayerChecked)
        {
            // grasz przeciwko graczowi
            Debug.Log("You play against another player!");
        }
        else
        {
            // grasz przeciwko AI - trzeba ustawi� poziom trudno�ci
            Debug.Log("You play against AI!");
        }
        
    }

    public void SetAIDifficulty(int difficulty)
    {
        // ustawia trudno�� AI
        Debug.Log("Difficulty of AI is changed");
    }

    public void SetGameDifficulty(int difficulty)
    {
        // ustawia trudno�� AI
        Debug.Log("Game difficulty is changed");
    }

    public void ChangeMapSize(int mapSizeIndex)
    {
        // ustawia trudno�� AI
        Debug.Log("Map size is changed");
    }
}
