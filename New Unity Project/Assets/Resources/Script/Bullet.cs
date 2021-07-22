using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerControler playerControler = other.GetComponent<PlayerControler>();

            if(playerControler != null)
            {
                playerControler.Die();
            }
        }
    }
}
