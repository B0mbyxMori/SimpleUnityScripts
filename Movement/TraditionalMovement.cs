// NOTE: Experimental player movement #2 ("Move in direction of z axis,
// rotate around y axis.").
// Moves player along the z axis. Rotates player around y axis
// enabling the player to turn around.

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
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.position = transform.position + transform.forward;

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.position = transform.position + (-transform.forward);

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            Vector3 rotate = new Vector3(transform.rotation.x,
                transform.rotation.y + (-45),
                transform.rotation.z);

            transform.Rotate(rotate);

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            Vector3 rotate = new Vector3(transform.rotation.x,
                transform.rotation.y + 45,
                transform.rotation.z);

            transform.Rotate(rotate);

            // Debug.Log("Remove if unnecessary.");
        }
    }
}
