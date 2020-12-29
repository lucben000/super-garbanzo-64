using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 Position;

    // Start is called before the first frame update
    void Start()
    {
        Position = new Vector2(4.28f, 1.28f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        }
    }
}