using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UImanager : MonoBehaviour
{
    public Image image1;
    public Image image2;

    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;
    public Image image11;
    public Image image12;

    public Image image13;
    public Transform Video;
    public Transform Video1;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 获取屏幕中心点
            Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);

            // 从屏幕中心发射射线
            Ray ray = Camera.main.ScreenPointToRay(screenCenter);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name =="ZTBl1")
                {
                    image1.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;

                }

                if (hit.collider.gameObject.name == "ZTBl2")
                {
                    image2.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }

                if (hit.collider.gameObject.name == "ZTBl3")
                {
                    image13.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }

                if (hit.collider.gameObject.name == "ZK1")
                {
                    image3.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }

                if (hit.collider.gameObject.name == "ZK2")
                {
                    image4.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZK3")
                {
                    image5.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZK4")
                {
                    image6.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZK5")
                {
                    image7.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }


                if (hit.collider.gameObject.name == "ZKCJ1")
                {
                    image8.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZKCJ2")
                {
                    image9.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZKCJ3")
                {
                    image10.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZKCJ4")
                {
                    image11.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if (hit.collider.gameObject.name == "ZKCJ5")
                {
                    image12.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                if(hit.collider.name==Video.name)
                {
                    VideoPlayer v1 = Video.GetComponent<VideoPlayer>();
                    if (v1.isPlaying)
                        v1.Stop();
                    else 
                        v1.Play();
                }
                if (hit.collider.name == Video1.name)
                {
                    VideoPlayer v1 = Video1.GetComponent<VideoPlayer>();
                    if (v1.isPlaying)
                        v1.Stop();
                    else
                        v1.Play();
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 关闭所有的Image对象
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(false);
            image3.gameObject.SetActive(false);
            image4.gameObject.SetActive(false);
            image5.gameObject.SetActive(false);
            image6.gameObject.SetActive(false);
            image7.gameObject.SetActive(false);
            image8.gameObject.SetActive(false);
            image9.gameObject.SetActive(false);
            image10.gameObject.SetActive(false);
            image11.gameObject.SetActive(false);
            image12.gameObject.SetActive(false);
            image13.gameObject.SetActive(false);
            // 隐藏鼠标光标
            Cursor.visible = false;
            // 锁定鼠标光标
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
