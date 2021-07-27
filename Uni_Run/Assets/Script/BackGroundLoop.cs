using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    [SerializeField] BoxCollider2D backgroundCollider;
    private float width;
    // Start is called before the first frame update
    private void Awake()
    {
        width = backgroundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -width)
        {
            Reposition();
        }    
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
