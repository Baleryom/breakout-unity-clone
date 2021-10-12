using UnityEngine;

public class Destroy : MonoBehaviour
{
    private KeepScore score;
    public int valueScore=100;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<KeepScore>();
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(transform.gameObject);
        score.Score += valueScore;
    }
}
