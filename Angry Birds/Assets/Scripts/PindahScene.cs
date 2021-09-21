using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // Update is called once per frame
    void Update () {
 
        //kondisi ketika kita menekan tombol A pada keyboard maka kita akan meload scene yang bernama "scene_satu"
        if (Input.GetKeyDown(KeyCode.A))            
        {
            //Method untuk memanggil / berpindah scene yang kita inginkan
            SceneManager.LoadScene("Main");
        }
        //Sedangkan ketika kita menekan tombol Q pada keyboard maka kita akan meload scene yang bernama "scene_dua"
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Main 1");
        }
 
    }

    public void PindahKeSceneDua()
    {
        SceneManager.LoadScene("Main 1");
    }
 
    public void PindahKeSceneSatu()
    {
        SceneManager.LoadScene("Main");
    }
}
