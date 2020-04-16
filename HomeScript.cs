using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home()
    {
        Debug.Log("Home button clicked");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
