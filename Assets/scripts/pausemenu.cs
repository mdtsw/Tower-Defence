using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
   
    public GameObject ui;
    bool paused = false;
    public string Menu = "Menu";
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P))
        {
            toggle();
        }
    }

    public  void toggle()
    {
        

        if(paused)
        {
            Time.timeScale = 1f;
            ui.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            ui.SetActive(true);

        }
    }

    public void retry()
    {
        toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu()
    {
        toggle();
        SceneManager.LoadScene(Menu);
    }
}
