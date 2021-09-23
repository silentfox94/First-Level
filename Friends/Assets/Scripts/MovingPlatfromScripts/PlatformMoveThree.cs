using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveTwo : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-2, 2, -3);
    private Vector3 pos2 = new Vector3(-2, 2, -8);
    private float speed = .35f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f)); 
    }
}
