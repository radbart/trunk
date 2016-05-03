using UnityEngine;
using System.Collections;

public class PaddleMover : MonoBehaviour {

    public int paddleForce;

    void Start()
    {
        Debug.Log("Game Start");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Paddle hit!");
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0, 4, paddleForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update () {

    }
}
