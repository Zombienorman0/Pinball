using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetBallPosition(Vector2 position)
    {
        rb.transform.position = position;
        rb.velocity = Vector2.zero;
    }

}
