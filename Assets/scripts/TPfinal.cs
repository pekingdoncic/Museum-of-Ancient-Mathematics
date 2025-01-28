using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPfinal : MonoBehaviour
{
    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(.5f); // 等待两秒

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); // 加载目标场景
    }

    private void Update()
    {
        // 从终点方块的位置向上发射一条射线
        Ray ray = new Ray(transform.position, Vector3.up);
        RaycastHit hit;

        // 如果射线与玩家方块发生碰撞
        if (Physics.Raycast(ray, out hit) && hit.collider != null)
        {
            StartCoroutine(LoadSceneAfterDelay());
        }
    }
}
