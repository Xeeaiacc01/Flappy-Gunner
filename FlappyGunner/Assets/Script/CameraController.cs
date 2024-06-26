using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform playerCamPos;
    [SerializeField]
    private float minHight = 0.0f;
    [SerializeField]
    private float maxHight = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        minHight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCamPos.transform.position;
    }
}
