using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static int box = 0;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject thua;
    void Start()
    {
        win.SetActive(false);
        thua.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( box == 3)
        {
            win.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Chạm: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("✅ Player chạm Dích!");
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            box++;
            Debug.Log("+1 Box, Total: " + box);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            box--;
            Debug.Log("-1 Box, Total: " + box);
        }
    }
}
