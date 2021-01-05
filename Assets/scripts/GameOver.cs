using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Text roundsText;
    public string Menu="Menu";
    void OnEnable()
    {
        roundsText.text = playerstats.rounds.ToString()+" Rounds Survived";
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu()
    {
        SceneManager.LoadScene(Menu);
    }
}
