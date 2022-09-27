using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool levelCompleted;
    public GameObject gameOverPanel;
    public GameObject levelCompletedPanel;

    public static int currentLevelIndex;
    public Slider gameProgressSlider;
    public TextMeshProUGUI currentLevelText;
    public TextMeshProUGUI nextLevelText;

    public static int numberOfPassedRings;
    // Start is called before the first frame update
    
    private void Awake()
    {
        currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
    }
    
    void Start()
    {
         Time.timeScale = 1;
         numberOfPassedRings = 0;
        gameOver = levelCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
          //update our ui
          currentLevelText.text = currentLevelIndex.ToString();
          nextLevelText.text = (currentLevelIndex+1).ToString();

         int progress = numberOfPassedRings * 100 / FindObjectOfType<HelixManager>().numberOfRings;
          gameProgressSlider.value = progress;
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            if(Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("level");
            }
        }
   

   
        if(levelCompleted)
        {
            Time.timeScale = 0;
            levelCompletedPanel.SetActive(true);

            if(Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("level");
            }
        }
   
    }
}
