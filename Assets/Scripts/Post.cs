using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Post : MonoBehaviour
{
    int interest;
    int anger;
    int fear;

    //when the mouse is dragging the Image gameobject this script attached to, change the position of the gameobject to the mouse position
    void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    //  void OnMouseDrag()
    // {
    //     // 计算鼠标位置
    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     Vector3 mousePosition = ray.GetPoint(10f);

    //     // 将物体移动到鼠标位置
    //     transform.position = mousePosition;
    // }
}
