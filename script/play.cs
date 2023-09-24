using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float playerRotationSpeed = 100.0f;
    void Update()
    {
        // Get the horizontal and vertical axis using arrow keys.
        // The value is in the range -1 to 1
        // Make it move 10 meters per second instead of 10 meters per frame...
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;
        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);
        // Update is called once per fram
        transform.Rotate(0, rotation, 0);
    }
}