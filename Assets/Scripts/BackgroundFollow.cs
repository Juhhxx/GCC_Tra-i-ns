using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float fixPos;
    [SerializeField] private PlayerWin win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (win.playerWin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, target.position.y + fixPos, transform.position.z);
        }
    }
}
