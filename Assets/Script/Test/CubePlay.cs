using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlay : MonoBehaviour
{
    bool isOver = false;
    void Update ()
    {
        if (isOver)
        {
            transform.localScale =
                Vector3.Lerp (transform.localScale,Vector3.one * 1.5f, Time.deltaTime * 10f);
        } 
        else 
        {
            transform.localScale = 
                Vector3.Lerp (transform.localScale,Vector3.one, Time.deltaTime * 5f);
        }
    }
    void OnMouseEnter ()
    {
        isOver = true;
    }
    void OnMouseExit ()
    {
        isOver = false;
    }
    //bool isDrag = false;
    void OnMouseDrag ()
    {
        Vector3 mousePoint = Input.mousePosition;
        Vector3 pos = Camera.main.ScreenToWorldPoint (
            new Vector3 (mousePoint.x, mousePoint.y, 10));
        /*Vector3 pos2 = Camera.main.ViewportToScreenPoint (
            new Vector3 (mousePoint.x / Screen.width,
                mousePoint.y / Screen.height,10f));
        transform.position = pos;*/
    }
}
