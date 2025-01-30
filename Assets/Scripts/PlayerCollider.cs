using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    Vector3 lastPos;

    public AudioSource checkpointSound;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillTrigger"))
        {
            transform.position = lastPos;
        }
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            lastPos = transform.position;
            checkpointSound.Play();
        }
    }
}