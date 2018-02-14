using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
    private Rigidbody2D rb;

	void Start ()
    {
        // Retrieve the Ridgidbody from gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
          	
	}
}
