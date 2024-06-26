using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float hitPower = 10;
    [SerializeField]
    private float timer = 1;
    [SerializeField]
    private float speed = 50;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, speed, ForceMode.Impulse);
        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,0);
        transform.position = new Vector3(rb.position.x,rb.position.y,0);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            collision.transform.SendMessage("Damage", hitPower, SendMessageOptions.DontRequireReceiver);
        }
    }
}
