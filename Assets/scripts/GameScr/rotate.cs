using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private bool isRotating = false;

    private void Update()
    {
        if (!isRotating && Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Rotate(Vector3.up, -90f, 1f));
        }
        else if (!isRotating && Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(Rotate(Vector3.up, 90f, 1f));
        }
    }

    private IEnumerator Rotate(Vector3 axis, float angle, float duration)
    {
        isRotating = true;

        Quaternion from = transform.rotation;
        Quaternion to = transform.rotation * Quaternion.Euler(axis * angle);

        float elapsed = 0f;
        while (elapsed < duration)
        {
            transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.rotation = to;
        isRotating = false;
    }
}
