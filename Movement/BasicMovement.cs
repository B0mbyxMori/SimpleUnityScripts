using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update.
    void Start()
    {
    }

    // Update is called once per frame.
    void Update()
    {
        float x_axis = Input.GetAxisRaw("Horizontal");
        float z_axis = Input.GetAxisRaw("Vertical"); // NOTE: Treating z_axis as vertical.

        transform.position = new Vector3(transform.position.x + (x_axis * speed),
            transform.position.y, // No jumping for now.
            transform.position.z + (z_axis * speed));

        // Debug.Log("x position: " + transform.position.x + (x_axis * speed));
        // Debug.Log("z position: " + transform.position.z + (z_axis * speed));
        // Debug.Log("y position: " + transform.position.y);
    }
}
