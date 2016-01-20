using UnityEngine;
using System.Collections;

public class MakeIt : MonoBehaviour {

    public GameObject hazard;
    public float n;

    // Use this for initialization
    void Start ()
    {
        for(int i = 0; i < n; i++)
        {
            for(int l = 0; l < n; l++)
            {
                Vector3 spawnPosition = new Vector3(i, 0, l);
                Quaternion spwanRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spwanRotation);
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
