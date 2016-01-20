using UnityEngine;
using System.Collections;

public class Size : MonoBehaviour {

    float n = Random.Range(10.0F, 100.0F);

    // Use this for initialization
    void Start ()
    {
        gameObject.transform.localScale = new Vector3(n, 0, n);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
