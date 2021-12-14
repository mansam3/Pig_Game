using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Rule : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("GameRule");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
