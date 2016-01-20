using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [SerializeField]
    float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }

        if (Input.GetKey("down"))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
