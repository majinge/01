using UnityEngine;

public class rotation : MonoBehaviour
{

    public GameObject B;

    float speed = 5.0f;
    Vector3[] direction = new Vector3[3] { Vector3.up, Vector3.forward, Vector3.right };
    void Start()
    {

    }
    void Update()
    {
        Vector3 temp = direction[Random.Range(0, 2)];
        transform.RotateAround(B.transform.position, temp, speed * Time.deltaTime);
    }
}
