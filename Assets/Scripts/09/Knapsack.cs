using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knapsack : MonoBehaviour
{
    public GameObject[] cells;
    public string[] equipmentsName;

    public GameObject item;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Pickup();
        }
    }


    public void Pickup()
    {
        int index = Random.Range(0, equipmentsName.Length);
        string name = equipmentsName[index];
        bool isFind = false;//表示找到了相同的格子 


        for (int i = 0; i < cells.Length; i++)
        {
            if (cells[i].transform.childCount >0)
            {
                var grid = cells[i].GetComponentInChildren<MyDragAndDrop>();
                if (grid.sp.spriteName == name)//表示找到了
                {
                    isFind = true;
                    grid.AddCount(1);
                    break;
                }
            }
        }

        if (!isFind)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].transform.childCount == 0)
                {
                    //当前位置没有物品
                    //添加物品
                    GameObject go = NGUITools.AddChild(cells[i], item);
                    go.GetComponent<UISprite>().spriteName = name;
                    go.transform.localPosition = Vector3.zero;

                    break;
                }
            }
        }
        

        
    }
}
