using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDragAndDrop : UIDragDropItem
{

    public UISprite sp;
    public UILabel label;

    private int count = 1;

    public void AddCount(int num = 1) 
    {
        count += num;
        label.text = count.ToString();
    }


    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);


        if (surface.tag=="Cell")
        {

            transform.parent = surface.transform;
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "Item")
        {
            var parent = surface.transform.parent;
            surface.transform.parent = transform.parent;
            surface.transform.localPosition = Vector3.zero;

            transform.parent = parent;
            transform.localPosition = Vector3.zero;
        }
    }
}
