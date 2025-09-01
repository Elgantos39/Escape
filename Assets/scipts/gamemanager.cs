using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
