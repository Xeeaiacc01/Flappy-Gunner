using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    private float forwardMaxSpeed=20f;
    [SerializeField]
    private float forwardAccelerator=10f;
    [SerializeField]
    private float jumpPower;


    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float velocity = rigidbody.velocity;
        if (velocity < forwardMaxSpeed)
            rigidbody.AddForce(0, 0, forwardAccelerator * Time.deltaTime);
    }
}
