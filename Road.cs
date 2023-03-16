using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Road";
        foreach (Transform child in transform)
        {
            child.gameObject.tag = "Road";
        }
        GameObject[] roadObjects = GameObject.FindGameObjectsWithTag("Road"); // Get an array of all game objects with the "Road" tag.
    
        foreach (GameObject roadObject in roadObjects) { // Loop through the array.
        if (roadObject.GetComponent<MeshCollider>() == null) { // Check if the game object doesn't already have a MeshCollider component.
            roadObject.AddComponent<MeshCollider>(); // Add a MeshCollider component to the game object.
        }
    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
