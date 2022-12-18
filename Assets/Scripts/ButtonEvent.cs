using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;
    public CharacterCustomiser characterCustomiser;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        //m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        characterCustomiser.Randomise();

    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }

}