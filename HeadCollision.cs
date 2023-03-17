using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollision : MonoBehaviour
{
    public Character vitesse; 

    // Start is called before the first frame update
    void Start()
    {
        vitesse = GetComponent<Character>();
    }
    
    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.transform.gameObject);
            vitesse.speed *= 2;
            yield return new WaitForSeconds(1f);
            vitesse.speed = vitesse.speed / 2;
        }
    }
}
