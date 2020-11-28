using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        int nextSceneToLoad;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
