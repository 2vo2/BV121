using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[RequireComponent(typeof(Button))]
public class NextButton : MonoBehaviour
{
    [SerializeField] private List<Image> _images;

    private Button _nextButton;
    private Image _currentImage;
    private int _currentImageIndex;

    public int CurrentImageIndex => _currentImageIndex;

    private void Awake()
    {
        _nextButton = GetComponent<Button>();
        ActiveImage(_images[0]);
    }

    private void ActiveImage(Image image)
    {
        image.color = Color.green;
        _currentImage = image;
    }

    private void DisableImage(Image image)
    {
        image.color = Color.red;
    }

    public void ChangeImage()
    {
        if (_currentImageIndex < _images.Count-1)
        {
            DisableImage(_currentImage);
            _currentImageIndex++;
            ActiveImage(_images[_currentImageIndex]);
        }
        else
        {
            DisableImage(_currentImage);
            _currentImageIndex = 0;
            ActiveImage(_images[_currentImageIndex]);
        } 
    }
}
