using UnityEngine;

public class ContentActivator : MonoBehaviour
{
    [SerializeField] private NextButton _nextButton;

    private int _currentContent;

    private void Start()
    {
        _currentContent = _nextButton.CurrentImageIndex;
        print(_currentContent);
    }
}
