using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Parallax : MonoBehaviour
{
	private float xlength, ylength, xstartpos, ystartpos;
		public GameObject cam;
		public float parallaxEffect;
	
    // Start is called before the first frame update
    void Start()
    {
        xstartpos = transform.position.x;
		ystartpos = transform.position.y;
		xlength = GetComponent<SpriteRenderer>().bounds.size.x;
		ylength = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xdist = (cam.transform.position.x * parallaxEffect);
		float ydist = (cam.transform.position.y * parallaxEffect);
		transform.position = new Vector3(xstartpos + xdist, ystartpos + ydist, transform.position.z);
    }
}
