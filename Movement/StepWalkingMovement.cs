// NOTE: Experimental player movement #1 ("Step walking").
// Might be useful if modified for jumping or zigzagging NPCs.

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

        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            gameObject.transform.position = new Vector3(transform.position.x,
                0.5f,
                transform.position.z + z_axis + 1);

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)) {
            gameObject.transform.position = new Vector3(transform.position.x,
                0.5f,
                transform.position.z + z_axis - 1);

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            gameObject.transform.position = new Vector3(transform.position.x + x_axis - 1,
                0.5f,
                transform.position.z);

            // Debug.Log("Remove if unnecessary.");
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            gameObject.transform.position = new Vector3(transform.position.x + x_axis + 1,
                0.5f,
                transform.position.z);

            // Debug.Log("Remove if unnecessary.");
        }
    }
}

