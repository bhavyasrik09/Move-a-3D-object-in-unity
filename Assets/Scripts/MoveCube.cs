using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal,0,vertical);
        transform.Translate(direction.normalized * Time.deltaTime * speed);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0,5),ForceMode.Impulse);
        }
    }
}
