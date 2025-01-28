using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateModel : MonoBehaviour
{
    public Transform modelTransform;
    private bool isRotate;
    private Vector3 startMousePosition;
    private Vector3 startModelRotation;
    private float rotateScale = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRotate)
        {
            isRotate = true;
            startMousePosition = Input.mousePosition;
            startModelRotation = modelTransform.eulerAngles;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isRotate = false;
        }
        if (isRotate)
        {
            Vector3 mouseDelta = Input.mousePosition - startMousePosition;

            // Adjust the rotation based on mouse movement
            Vector3 rotation = new Vector3(mouseDelta.y, -mouseDelta.x, 0) * rotateScale;


            // Apply the rotation to the model
            modelTransform.eulerAngles = startModelRotation + rotation;
        }
    }
}
