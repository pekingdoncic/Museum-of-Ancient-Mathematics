using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TiaoZhuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        SceneManager.LoadScene("Game");
    }
    public void EnterRiGui()
    {
        SceneManager.LoadScene("Standard Demo");
    }
    public void ExitRiGui()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
