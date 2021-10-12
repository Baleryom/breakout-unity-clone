using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public string TimeWinCondition { get { return time; } set { time = value; } }
    private string time = "0,00";
    private float lastTime =0;
    private KeepScore scoreScript;
    private string highScore;
    string savedHighscore;
    void Start()
    {
        scoreScript = GameObject.Find("Score").GetComponent<KeepScore>();
        savedHighscore = PlayerPrefs.GetString("highscore");
        if (savedHighscore == "")
        {
            PlayerPrefs.SetString("highscore", "0,00");
            savedHighscore = PlayerPrefs.GetString("highscore");
        }
    }
    void Update()
    {
        if (!LookForChild("MiniCapsule"))
        {
            savedHighscore = PlayerPrefs.GetString("highscore");
            highScore = scoreScript.Score.ToString();
          
            if (float.Parse(highScore) > float.Parse(PlayerPrefs.GetString("highscore")))
             {
              PlayerPrefs.SetString("highscore", highScore);
             }
        }
        var str = (Time.realtimeSinceStartup - lastTime).ToString();
        time = RemoveCommaNumbers(str);
    }

    private string RemoveCommaNumbers(string str)
    {
        return str.Remove(str.Length - 3, 3);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(800, 25, 100, 20), time);
    }

    private bool LookForChild(string NameGO)
    {
        foreach (Transform eachChild in transform)
        {
            if (eachChild.name.StartsWith(NameGO))
            {
                return true;
            }
        }
        return false;
    }
}
