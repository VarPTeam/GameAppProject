using UnityEngine;
using System.Collections;

public class Ping1Controls : MonoBehaviour {

    public float speed = 10;
    public string axis = "Vertical";

    void FixedUpdate ()
    {
        // movimento in verticale dei ping
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }

}
