using UnityEngine;

public class KitchenHandler : MonoBehaviour
{
    private ButtonScript buttonScript;

    void Start()
    {
        GameObject logicObj = GameObject.FindWithTag("ButtonController");
        if (logicObj != null)
        {
            buttonScript = logicObj.GetComponent<ButtonScript>();
        }
        else
        {
            Debug.LogError("ButtonScript not found!");
        }
    }

    public void AddIngredientByName(string ingredient)
    {
        buttonScript?.OnButtonClickIngredient(ingredient);
    }

    public void ConfirmDrink()
    {
        Debug.Log("Confirm clicked.");
        buttonScript?.OnConfirmClick();
    }
}
