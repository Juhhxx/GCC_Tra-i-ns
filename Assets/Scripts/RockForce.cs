using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockForce : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float rollSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentVelocity = rb.velocity;
        Vector3 velocity = new Vector3(rollSpeed, currentVelocity.y, currentVelocity.z);

        rb.velocity = velocity;

    }
}
