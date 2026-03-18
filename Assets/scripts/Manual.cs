using UnityEngine;

public class Manual : MonoBehaviour
{
    public static bool HasManual;

    void Start()
    {
        HasManual = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HasManual = true;
            gameObject.SetActive(false);
        }
    }
}
