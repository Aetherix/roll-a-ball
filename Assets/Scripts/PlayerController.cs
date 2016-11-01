using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody _rb;
    private int _count;

    public float Speed = 1;
    public Text countText;
    public Text winText;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _count = 0;
        SetCountText();
        winText.text = "";
    }

    // For physics stuff
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        _rb.AddForce(movement * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            _count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + _count.ToString();
        if (_count >= 14)
        {
            winText.text = "You win!";
        }
    }
}
