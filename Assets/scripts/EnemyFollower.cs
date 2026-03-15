using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollower : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField]
    private float runningSpeed = 6f;
    [SerializeField]
    bool isRunner;
    private Rigidbody2D rb;


    private Vector2 movementDirector;


    Transform playerTransform;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movementDirector = playerTransform == null? Vector2.zero : (playerTransform.position - transform.position).normalized;
    }
    void FixedUpdate()
    {
        float currentSpeed = isRunner ? runningSpeed : movementSpeed;
        rb.linearVelocity = movementDirector * currentSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") ){
            playerTransform = collision.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            playerTransform = null;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ReloadScene();
        }
    }
    public void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
