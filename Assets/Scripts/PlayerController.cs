using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10;
	public float jumpForce = 100;
    public int minJumpSpan = 30;

    private Camera camera;

    private int jumpCount;

	// Use this for initialization
	void Start () {
        var rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 100;
        jumpCount = minJumpSpan;
        camera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        if (jumpCount < minJumpSpan) jumpCount++;
	}

	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

        if ((x == 0) && (z == 0)) return;

        Vector3 viewTorque = new Vector3(z * speed, 0, x * speed * -1);
        viewTorque = Quaternion.Euler(0,camera.transform.rotation.eulerAngles.y,0) * viewTorque;

        Rigidbody rb = GetComponent<Rigidbody> ();
        rb.AddTorque(viewTorque);
		//rb.AddTorque(z * speed, 0, x * speed * -1);
	}

    void OnCollisionStay (Collision col)
    {
		Rigidbody rb = GetComponent<Rigidbody> ();
		bool y = Input.GetKey(KeyCode.Space);
        if (y && (jumpCount >= minJumpSpan))
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            jumpCount = 0;
        }

    }
}
