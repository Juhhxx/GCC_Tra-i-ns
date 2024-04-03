using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockForce : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float rollSpeed = 90f;
    [SerializeField] private GameObject trSlow;
    [SerializeField] private CircleCollider2D col;

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
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == trSlow.name)
        {
            rollSpeed = 0f;
        }
    }

}
