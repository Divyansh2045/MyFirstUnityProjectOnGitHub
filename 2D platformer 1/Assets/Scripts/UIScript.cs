using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class UIScript : MonoBehaviour
{
    public Button button;
    public string NewScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(NewScene);
    }
}

  
