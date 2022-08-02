using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollChoose : MonoBehaviour
{
    public int id = 0;

    [SerializeField,Header("主要顯示的圖片")] Image image;

    [SerializeField,Header("角色清單")] List<Image> objects = new List<Image>();

    /// <summary>
    /// 滑動時變更圖片數值
    /// </summary>
    /// <param name="vector"></param>
    public void valueChange(Vector2 vector)
    {
        Debug.Log(vector);
        id = (int)vector.x; //因為vector是二為向量，但我們只取水平的X並強制轉型為整數
        switch (id)
        {
            case 0:
                image.sprite = objects[0].sprite;
                break;
            case 4:
                image.sprite = objects[1].sprite;
                break;
            case 7:
                image.sprite = objects[2].sprite;
                break;
            case -1:
                image.sprite = objects[3].sprite;
                break;
            case -4:
                image.sprite = objects[4].sprite;
                break;
        }
    }
}
