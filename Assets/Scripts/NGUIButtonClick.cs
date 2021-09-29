using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUIButtonClick : MonoBehaviour
{
    public void OnLabelButtonClick() 
    {
        Debug.Log("Label");
    }

    public void OnSpriteButtonClick() 
    {
        Debug.Log("Sprite");
    }
}
