using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool gameOver = false;
    private void OnTriggerEnter(Collider other)
    {
        gameOver = true;
    }

    private void OnGUI()
    {
        if (gameOver)
        {
             if(GUI.Button(new Rect(10, 10, 100, 20), "Play again"))
            {
                SceneManager.LoadScene("Main");
            }
        }
       
    }
}
