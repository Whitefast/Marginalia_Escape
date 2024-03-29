using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite sp1,sp2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            GetComponent<SpriteRenderer>().sprite = sp1;
        if (Input.GetKeyDown(KeyCode.O))
            GetComponent<SpriteRenderer>().sprite = sp2;
    }

}
