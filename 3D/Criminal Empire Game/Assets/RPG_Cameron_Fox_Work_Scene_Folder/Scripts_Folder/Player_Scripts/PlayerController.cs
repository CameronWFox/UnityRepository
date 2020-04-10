using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int testCount;

    public float speed;
    public Text testPickupCountText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Ability to freeze rotation information found from a post on Stack Exchange
        // I have the link to question and answer as well if interested.
        GetComponent<Rigidbody>().constraints = 
            RigidbodyConstraints.FreezeRotationX | 
            RigidbodyConstraints.FreezeRotationZ;

        testCount = 0;
        SetPickupCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            testCount = testCount + 1;
            SetPickupCountText();
        }
    }

    void SetPickupCountText()
    {
        testPickupCountText.text = "Test Pickup Count: " + testCount.ToString();

    }
}
