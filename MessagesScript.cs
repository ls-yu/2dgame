using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagesScript : MonoBehaviour
{
    public void Messages()
    {
        Debug.Log("Messages button clicked");
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
