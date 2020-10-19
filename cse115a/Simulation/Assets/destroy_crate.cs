using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_crate : MonoBehaviour
{
    public GameObject destroyedCrate;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Instantiate(destroyedCrate, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
