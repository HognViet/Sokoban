using UnityEngine;

public class Bay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject thua;
    void Start()
    {
        thua.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            thua.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
