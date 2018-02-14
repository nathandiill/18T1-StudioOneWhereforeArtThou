using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    void Awake()
    {
        Instance = this;
    }

    private Rigidbody2D rb;
    private Vector2 userInput;
    public float movementSpeed = 5.0f;

	void Start ()
    {
        // Retrieve the Ridgidbody from gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

   
    void Update ()
    {
        // Retrieve user input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = 0;
        userInput = new Vector2(horizontal, vertical);
    }

    void FixedUpdate()
    {
        // Call movement in FixedUpdate
        Vector2 newPosition = transform.position;
        newPosition += userInput * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
