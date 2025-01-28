using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPfinal : MonoBehaviour
{
    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(.5f); // �ȴ�����

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); // ����Ŀ�곡��
    }

    private void Update()
    {
        // ���յ㷽���λ�����Ϸ���һ������
        Ray ray = new Ray(transform.position, Vector3.up);
        RaycastHit hit;

        // �����������ҷ��鷢����ײ
        if (Physics.Raycast(ray, out hit) && hit.collider != null)
        {
            StartCoroutine(LoadSceneAfterDelay());
        }
    }
}
