using UnityEngine;
using System.Collections;

public class createBox : MonoBehaviour {

	public float i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		i += Time.deltaTime;
		if (i > 1f) {
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			DestroyImmediate (cube.GetComponent<BoxCollider> ());
			cube.AddComponent<Rigidbody2D>();
			cube.AddComponent<BoxCollider2D> ();
			cube.GetComponent<Rigidbody2D> ().mass = 100f;
			cube.transform.localScale = new Vector3 (5, 5, 0);
			cube.transform.position = new Vector3 (0, 0, -10);
			i = 0;
		}
	}

	/*void onMouseDown {
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		DestroyImmediate (cube.GetComponent<BoxCollider> ());
		cube.AddComponent<Rigidbody2D>();
		cube.AddComponent<BoxCollider2D> ();
		cube.GetComponent<Rigidbody2D> ().mass = 0.1f;
		cube.transform.localScale = new Vector3 (6, 6, 0);
		cube.transform.position = new Vector3 (0, 0, 40);
	}*/
}
