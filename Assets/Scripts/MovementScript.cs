using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 8f; // Adjust this value to set the movement speed
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
         //Get the horizontal input (A and D keys or left and right arrow keys)
         float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        // Move the object based on the input and speed
        Player.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
