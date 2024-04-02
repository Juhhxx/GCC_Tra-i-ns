using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private Animator animSelf;
    private Rigidbody2D rg;

    [SerializeField] private float decelaration = 5;
    [SerializeField] private float accelaration = 10;
    [SerializeField] private float maxVelocity = 100f;
    private float velocityX = 0f;
    private List<string> keysPressed = new List<string>() { "Left", "Right" };

    // Start is called before the first frame update
    void Start()
    {
        animSelf = GetComponent<Animator>();
        rg = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (velocityX > 0f) 
        {
            velocityX -= decelaration;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            //anim.Play("pulley_left");
            anim.SetTrigger("left");
            keysPressed.Add("Left");
            keysPressed.RemoveAt(0);
            if (keysPressed[0] != keysPressed[1])
            {
                velocityX += accelaration;
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            //anim.Play("pulley_right");
            anim.SetTrigger("right");
            keysPressed.Add("Right");
            keysPressed.RemoveAt(0);
            if (keysPressed[0] != keysPressed[1])
            {
                velocityX += accelaration;
            }
        }

        velocityX = Mathf.Clamp(velocityX, 0f, maxVelocity);

        Debug.Log($"({keysPressed[0]}, {keysPressed[1]})");

        Vector3 currentVelocity = rg.velocity;
        Vector3 velocity = new Vector3 (velocityX, currentVelocity.y, currentVelocity.z);

        Debug.Log($"Velocity: {velocity.x}");
        rg.velocity = velocity;

    }
}
