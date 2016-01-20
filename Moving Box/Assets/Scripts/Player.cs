using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] Material col;
    float red = 0.05f;
    float blue = 0.25f;
    float green = 0.5f;

    // Use this for initialization
    void Start ()
    {
        gameObject.transform.position = new Vector3(300, 0, 300);
	}

    // Making some functions for no reason :[ //
    void Lerp(float a, float b, float c)
    {
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
    }

    // Update is called once per frame
    void Update ()
    {
    if (red >= 1)
        {
            red = 0;
        }
    else
        {
            red += 0.01f;
        }

    if (blue >= 1)
        {
            blue = 0;
        }
    else
        {
            blue += 0.025f;
        }

    if (green >= 1)
        {
            green = 0;
        }
    else
        {
            green += 0.005f;
        }

        // --------------------------------------------------//
        if (Input.GetKey("up"))
        {
            Lerp(0, 0, 1 * Time.deltaTime * speed);
        }

    if (Input.GetKey("down"))
        {
            Lerp(0, 0, -1 * Time.deltaTime * speed);
        }

    if (Input.GetKey("left"))
        {
            Lerp(-1 * Time.deltaTime * speed, 0, 0);
        }

    if (Input.GetKey("right"))
        {
            Lerp(1 * Time.deltaTime * speed, 0, 0);
        }

    if (Input.GetKey("b"))
        {
            if (gameObject.transform.position != new Vector3(300, 0.5f, 300))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + ((300 - gameObject.transform.position.x) * Time.deltaTime * speed), 0.5f, gameObject.transform.position.z + ((300 - gameObject.transform.position.z) * Time.deltaTime * 50));
            }
        }

    if (Input.GetKey("space"))
        {
            if (gameObject.transform.position.y <= 0.6)
            {
                Lerp(0, 1 * Time.deltaTime * speed, 0);
            }
        }
        col.SetColor("_Color", new Color(red, blue, green, 1));
    }

}
