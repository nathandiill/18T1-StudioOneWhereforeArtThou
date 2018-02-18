using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
    public Rigidbody2D rb;

	void Start ()
    {
        // Retrieve the Ridgidbody from gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();

        Physics2D.gravity = Vector2.zero;
    }
	
	void Update ()
    {
        
    }
}
