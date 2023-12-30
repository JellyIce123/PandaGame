using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    public float fallSpeed; // Adjust this value to set the falling speed
    private UIManager UIManager;

    private void Start()
    {
        UIManager = FindObjectOfType<UIManager>();
    }
    // Update is called once per frame
    void Update()
    {
        // Move the object down along the y-axis
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a specific tag
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.IncreasePoints();
            // Destroy the falling object when it collides with an object having the specified tag
            Destroy(gameObject);
        }

        // Check if the colliding object has a specific tag
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Destroy the falling object when it collides with an object having the specified tag
            Destroy(gameObject);
        }
    }
}
