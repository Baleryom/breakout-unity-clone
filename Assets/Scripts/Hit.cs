using UnityEngine;

public class Hit : MonoBehaviour
{
    public float hitForce = 50;

    void OnCollisionEnter(Collision collision)
    {
        Vector3 newTransform = transform.position;
        newTransform = new Vector3(transform.position.x, collision.transform.position.y * -1, collision.transform.position.z * -1);
        transform.GetComponent<Rigidbody>().AddForce(newTransform * hitForce);
    }
}
