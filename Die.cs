using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Die : MonoBehaviour
{
    private void Update(){
        if(transform.position.y < -18f){
            Dying();
        }
    }
    
    
    public void Dying(){
        Invoke(nameof(reloadLevel), 1.3f);
    }
    void reloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}