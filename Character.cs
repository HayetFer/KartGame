using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Character : MonoBehaviour
{
    [SerializeField] public float speed = 15.0f;
    [SerializeField] public float rotationSpeed = 50f;
    public bool isSelected = false;

    public string Thisname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation*2, 0);
        
    }
    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.transform.gameObject);
            speed *= 2;
            yield return new WaitForSeconds(1f);
            speed = speed / 2;
        }
        else if (collision.gameObject.CompareTag("YellowEnemy"))
        {
            Destroy(collision.transform.gameObject);
            float precedentSpeed = speed;
            speed *= -2;
            yield return new WaitForSeconds(1f);
            speed =
                precedentSpeed;
        }
        else if (collision.gameObject.CompareTag("RedEnemy"))
        {
            Destroy(collision.transform.gameObject);
            StartCoroutine(RotateCharacter());
            
        }
    }
    IEnumerator RotateCharacter()
    {
        float angleRotated = 0;

        while (angleRotated < 360f)
        {
            transform.Rotate(Vector3.up, angleRotated*2); // rotate the character around the y-axis
            angleRotated ++;
            yield return null; // wait for the next frame
        }
    }
}

