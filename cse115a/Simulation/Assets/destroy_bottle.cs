using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bottle : MonoBehaviour
{
    public GameObject destroyedBottle;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Instantiate(destroyedBottle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
