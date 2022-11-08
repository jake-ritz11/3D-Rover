using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public bool isFailed;
    public bool isWin;

    // Start is called before the first frame update
    void Start()
    {
        isFailed = false;
        isWin = false;
    }

    private void Update()
    {
        if(isFailed == true)
        {
            UI.instance.failedUI.SetActive(true);
        }
        if (isWin == true)
        {
            UI.instance.winUI.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            isFailed = true;
        }
        if(collision.gameObject.name == "Win")
        {
            isWin = true;
        }
    }
}
