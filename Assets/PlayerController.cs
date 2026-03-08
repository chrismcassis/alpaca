using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField]
    private float runningSpeed = 6f;
    private Rigidbody2D rb;

    private Vector2 movementDirector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runningSpeed : movementSpeed;
        rb.linearVelocity = movementDirector * currentSpeed; 
    }
}
