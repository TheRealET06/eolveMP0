using UnityEngine;
using UnityEngine.UI;

public class CreditMenuButton : MonoBehaviour
{

    public Button m_Back_Button, m_YourSecondButton, m_YourThirdButton, m_QuitButton;
    public GameObject myPrefab;
    public GameObject mainMenu;
    public GameObject creditMenu;
    //public GameObject CreditMenu;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        m_Back_Button.onClick.AddListener(BackToMainMenu);
        // m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        // m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        // m_YourThirdButton.onClick.AddListener(TaskOnClick);
        m_QuitButton.onClick.AddListener(QuitButtonOnClick);
    }

    public void SetMainMenu(GameObject menu)
    {
        mainMenu = menu;
    }

    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        Destroy(creditMenu);
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