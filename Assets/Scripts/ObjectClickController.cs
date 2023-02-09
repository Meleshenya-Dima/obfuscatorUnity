using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickController : MonoBehaviour, IPointerClickHandler
{
    private Transform _objectClick;

    public Text text;

    private int _countClick;

    void Start()
    {
        _objectClick = gameObject.GetComponent<Transform>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_objectClick.tag.Equals("Enemy"))
        {
            _countClick++;
            text.text = _countClick.ToString();
        }
    }
}
