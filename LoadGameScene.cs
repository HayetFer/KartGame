using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] character;
    void Start()
    {
        int playerScore = PlayerPrefs.GetInt("PlayerScore");
        character[playerScore].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
