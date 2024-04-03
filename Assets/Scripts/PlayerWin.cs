using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    [SerializeField] private GameObject winTr;
    [SerializeField] private GameObject menu;
    private Collider2D col;

    public bool playerWin = false;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == winTr.name)
        {
            playerWin = true;
            menu.SetActive(true);
        }
    }
}
