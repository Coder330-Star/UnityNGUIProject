using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHUDText : MonoBehaviour
{
    public HUDText hud;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hud.Add(-10, Color.red, 0.1f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            hud.Add(+10, Color.green, 0.1f);
        }
    }
}
