using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCounter : MonoBehaviour
{
    public int counter = 0;

    public void Increase() {
        counter++;
    }
    // Update is called once per frame
    void Update()
    {
        if (counter > 0) {
            //load next scene
            SceneManager.LoadScene("Title Screen");
        } 
    }
}
