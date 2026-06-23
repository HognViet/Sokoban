using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static int box = 0;
    [SerializeField] private GameObject win;
    private bool isGameOver = false;
    
    void Start()
    {
        win.SetActive(false);
        
    }


    // Update is called once per frame
    void Update()
    {
        if ( box == 3 && !isGameOver)
        {
            win.SetActive(true);
            isGameOver = true;
            //Debug.Log(box);
            //Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            box++;
            Debug.Log("+1 Box, Total: " + box);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            box--;
            Debug.Log("-1 Box, Total: " + box);
        }
    }
    public void ChsLai()
    {
        //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

}
