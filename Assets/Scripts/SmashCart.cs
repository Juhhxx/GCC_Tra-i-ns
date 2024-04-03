using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCart : MonoBehaviour
{
    [SerializeField] private GameObject cart;
    [SerializeField] private Animator animC;
    [SerializeField] private CircleCollider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == cart.name)
        {
            animC.SetTrigger("dead");
            Debug.Log("HIT");
        }
    }
}
