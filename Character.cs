using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public float speed = 15.0f;
    [SerializeField] public float rotationSpeed = 50f;

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
        transform.Rotate(0, rotation*3, 0);
        
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
            speed *= 0;
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
        float duration = 1f; // duration of rotation in seconds
        float anglePerSecond = 360f / duration; // calculate the angle to rotate per second
        float angleRotated = 0f;

        while (angleRotated < 360f)
        {
            float angleThisFrame = anglePerSecond * Time.deltaTime;
            transform.Rotate(Vector3.up, angleThisFrame); // rotate the character around the y-axis
            angleRotated += angleThisFrame;
            yield return null; // wait for the next frame
        }
    }
}

