using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 10f;
    private float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (time > 0.5f)
            {
                GameManager.instance.AddScore(10);
                time = 0f;
            }
        }
    }
}
