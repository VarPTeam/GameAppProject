using UnityEngine;
using System.Collections;

public class PallaScript : MonoBehaviour {

    public float speed = 10;
    float hitFactor (Vector2 pallaPos, Vector2 pingPos,
                    float pingHeight)
    {
        return (pallaPos.y - pingPos.y) / pingHeight;
    }
	// Use this for initialization
	void Start () {
        // velocitá iniziale
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        

        //colpisce il ping sinistro
        if (col.gameObject.name == "Ping1")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);
            //calco direzione
            Vector2 dir = new Vector2(1, y).normalized;

            //set velocity
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        //colpisce il pind destro
        if (col.gameObject.name == "Ping2")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);
            //calco direzione
            Vector2 dir = new Vector2(-1, y).normalized;

            //set velocity
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "MuroDestro")
        {
            
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
