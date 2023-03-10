using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update.
    void Start()
    {
        // Finds Player parent and points 'player' to object.
        player = GameObject.Find("Player");
    }

    // Update is called once per frame.
    void Update()
    {
        // Align to player position.
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}
