using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartDeath : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -100)
        {
            anim.SetTrigger("dead");
        }
        
    }

    void Death()
    {
        menu.SetActive(true);
        Destroy(gameObject);
    }
}
