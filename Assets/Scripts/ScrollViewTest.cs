using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewTest : MonoBehaviour
{
    public UITextList label;
    private int index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            label.Add($"测试是第几行....{ index}");
            index++;
        }
    }
}
