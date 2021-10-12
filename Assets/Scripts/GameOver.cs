using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool gameOver = false;
    private WinCondition wincon;
    private void Start()
    {
        wincon = GameObject.Find("Score").GetComponent<WinCondition>();
    }
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
            GUI.Label(new Rect(25, 35, 100, 20), $"Highscore : {PlayerPrefs.GetString("highscore")}");

        }
       
    }
}
