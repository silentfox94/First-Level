using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveOne : MonoBehaviour
{
    private GameObject target = null;
    private Vector3 offset;
    private Vector3 pos1 = new Vector3(-2, 2, 3);
    private Vector3 pos2 = new Vector3(-2, 2, 12);
    private float speed = .35f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }


    void Start()
    {
        target = null;
    }
    void OnTriggerStay(Collider col)
    {
        target = col.gameObject;
        offset = target.transform.position - transform.position;
    }
    void OnTriggerExit(Collider col)
    {
        target = null;
    }
    void LateUpdate()
    {
        if (target != null)
        {
            target.transform.position = transform.position + offset;
        }
    }
}
