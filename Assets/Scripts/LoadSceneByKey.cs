using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}