using UnityEngine;

public class CategoryToggle : MonoBehaviour
{
    
    public GameObject scrollView;

    private bool isVisible = false;

    void Start()
    {
        if (scrollView != null)
        {
            // Hide the scroll view when the scene starts
            scrollView.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Scroll View is not assigned on " + gameObject.name);
        }
    }

    // This function can be linked to the OnClick() event of the category icon or button
    public void ToggleCategory()
    {
        if (scrollView != null)
        {
            isVisible = !isVisible;
            scrollView.SetActive(isVisible);
        }
    }
}
