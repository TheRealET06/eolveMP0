using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{

    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, m_QuitButton, gameMenuButton;
    public GameObject myPrefab, gameMenu;
    public GameObject mainMenu;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        m_YourFirstButton.onClick.AddListener(delegate { TaskWithParameters("Continue"); }); 
        m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        m_YourThirdButton.onClick.AddListener(TaskOnClick);
        m_QuitButton.onClick.AddListener(QuitButtonOnClick);
        gameMenuButton.onClick.AddListener(goToGameMenu);
    }

    void goToGameMenu()
    {
        Debug.Log("You have gone to the game!");
        mainMenu.SetActive(false);
        GameObject credits = Instantiate(gameMenu, new Vector3(0, 0, 0), Quaternion.identity);

        CreditMenuButton thecBut = credits.GetComponentInChildren<CreditMenuButton>();
        thecBut.SetMainMenu(mainMenu);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        mainMenu.SetActive(false);
        GameObject credits = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        CreditMenuButton thecBut = credits.GetComponentInChildren<CreditMenuButton>();
        thecBut.SetMainMenu(mainMenu);
    }

    void TaskWithParameters(string message)
    {
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        Debug.Log("Button clicked = " + buttonNo);
    }

    void QuitButtonOnClick()
    {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
