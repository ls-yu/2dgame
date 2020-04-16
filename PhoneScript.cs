using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Phone()
    {
        Debug.Log("Phone button clicked");
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
