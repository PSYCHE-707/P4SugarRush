using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AveryController : MonoBehaviour
{
    public float speed = 2.0f;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (Input.GetKeyDown(KeyCode.L))
        {
            speed = 3.0f;
        }
    }
}
