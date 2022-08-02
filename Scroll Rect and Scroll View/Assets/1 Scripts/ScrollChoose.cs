using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollChoose : MonoBehaviour
{
    public int id = 0;

    [SerializeField,Header("�D�n��ܪ��Ϥ�")] Image image;

    [SerializeField,Header("����M��")] List<Image> objects = new List<Image>();

    /// <summary>
    /// �ưʮ��ܧ�Ϥ��ƭ�
    /// </summary>
    /// <param name="vector"></param>
    public void valueChange(Vector2 vector)
    {
        Debug.Log(vector);
        id = (int)vector.x; //�]��vector�O�G���V�q�A���ڭ̥u��������X�ñj���૬�����
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
