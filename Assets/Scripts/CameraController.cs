using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private Vector3 offset;

    public GameObject _player;

    // Use this for initialization
    void Start () {
        offset = transform.position - _player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = _player.transform.position + offset;
	}
}
