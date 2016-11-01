using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    public float Speed = 50f;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0, 0, Speed) * Time.deltaTime);
	}
}
