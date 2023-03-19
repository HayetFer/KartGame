using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayetButton : MonoBehaviour
{
    public GameObject[] Persos;
    public int playerScore;

    /*public void active()
    {
        Persos[hayetObject].SetActive(true);
    }*/
    public void newGameButton()
    {
        playerScore = 0;
        SceneManager.LoadScene("Game");
        PlayerPrefs.SetInt("PlayerScore", playerScore);
    }

    
}