using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    private Transform bullet;
    [SerializeField]
    private Transform bulletPos;
    [SerializeField]
    private float forwardMaxSpeed=20f;
    [SerializeField]
    private float forwardAccelerator=10f;
    [SerializeField]
    private float jumpPower;


    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            JumpShot();
        }
    }

    private void FixedUpdate()
    {
        float velocity = rb.velocity.magnitude;
        if (velocity < forwardMaxSpeed)
            rb.AddForce(forwardAccelerator * Time.deltaTime, 0, 0,ForceMode.Force);


    }

    private void JumpShot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            bulletPos.LookAt(new Vector3(hit.point.x,hit.point.y,transform.position.z));
            Transform mBullet = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        }
        rb.AddForce(0, jumpPower, 0, ForceMode.Impulse);
    }
}
