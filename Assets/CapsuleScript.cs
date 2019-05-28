using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float Rotation = Input.GetAxis("Horizontal");
		transform.Rotate(new Vector3(0, 0, -Rotation));

		RaycastHit hit;

		Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 10f, Color.red);

		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity))
		{
			hit.collider.gameObject.GetComponent<CubeScript>().BeenHit();
			Debug.Log("I've hit something!");
		}
    }
}
