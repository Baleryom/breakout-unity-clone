using UnityEngine;

public class SpawnCapsulesScript : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Transform startPoint;
    public Transform endPoint;
    public Transform endPointRow;
    void Start()
    {
        for (float z = startPoint.position.z; z < endPoint.position.z; z += 0.9f)
        {
            for (float y = startPoint.position.y; y > endPointRow.position.y; y -= 1.6f)
            {
                Vector3 newPos = startPoint.position;
                GameObject go = GameObject.Instantiate(capsulePrefab, new Vector3(startPoint.position.x, y, z), transform.rotation, transform) as GameObject;
                go.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                var randomNumber = Random.RandomRange(1, 5);
                go.GetComponent<Capsule>().Hp = randomNumber;
                go.GetComponentInChildren<TextMesh>().text = randomNumber.ToString();
            }
        }
    }
}
