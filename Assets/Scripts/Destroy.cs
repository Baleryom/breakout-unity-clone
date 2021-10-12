using UnityEngine;

public class Destroy : MonoBehaviour
{
    private KeepScore score;
    private Capsule capsule;
    public int valueScore=100;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<KeepScore>();
        capsule = transform.gameObject.GetComponent<Capsule>();
    }
    void OnCollisionExit(Collision collision)
    {
        if(capsule.Hp == 0)
        {
            Destroy(transform.gameObject);
            score.Score += valueScore;
        }
        else
        {
            capsule.Hp--;
            capsule.GetComponentInChildren<TextMesh>().text = capsule.Hp.ToString();
        }
        
        
    }
}
