using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Role_choice : MonoBehaviour
{
    [Header("角色資料")]public GameObject[] figure;

    [Header("位置判定")]public GameObject canScroll;

    private void Start()
    {
    }
    private void Update()
    {
        Debug.Log(canScroll.transform.position);
    }
    /// <summary>
    /// 偵測腳色選項
    /// </summary>
    public void ScrollCalueChange()
    {
        if (350 < canScroll.transform.position.x) figure[0].gameObject.SetActive(true);
        else figure[0].gameObject.SetActive(false);
        if (180 < canScroll.transform.position.x && canScroll.transform.position.x < 349) figure[1].gameObject.SetActive(true);
        else figure[1].gameObject.SetActive(false);
        if (10 < canScroll.transform.position.x && canScroll.transform.position.x < 179) figure[2].gameObject.SetActive(true);
        else figure[2].gameObject.SetActive(false);
        if (-160 < canScroll.transform.position.x && canScroll.transform.position.x < 9) figure[3].gameObject.SetActive(true);
        else figure[3].gameObject.SetActive(false);
        if (-340 < canScroll.transform.position.x && canScroll.transform.position.x < -161) figure[4].gameObject.SetActive(true);
        else figure[4].gameObject.SetActive(false);
        if (-520 < canScroll.transform.position.x && canScroll.transform.position.x < -341) figure[5].gameObject.SetActive(true);
        else figure[5].gameObject.SetActive(false);
        if (-700 < canScroll.transform.position.x && canScroll.transform.position.x < -521) figure[6].gameObject.SetActive(true);
        else figure[6].gameObject.SetActive(false);
        if (canScroll.transform.position.x < -701) figure[7].gameObject.SetActive(true);
        else figure[7].gameObject.SetActive(false);
    }
}
