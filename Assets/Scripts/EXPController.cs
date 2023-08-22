using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EXPController : MonoBehaviour
{
    private bool _isShowing = false;
    VisualElement root;
    private GroupBox _expGroup;


    //public UIControl ui;

    // Start is called before the first frame update

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _expGroup = root.Q<GroupBox>("EXP");

    }

    void Start()
    {
        _expGroup.SetEnabled(false);
        _expGroup.style.display = DisplayStyle.None;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_isShowing)
        {
            if (other.CompareTag("Player"))
            {
                _isShowing = true;
                ShowEXP();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_isShowing)
        {
            if (other.CompareTag("Player"))
            {
                _isShowing = false;
                HideEXP();
            }
        }
    }


    public void ShowEXP()
    {
        _expGroup.style.display = DisplayStyle.Flex;
        _expGroup.SetEnabled(true);
    }
    public void HideEXP()
    {
        _expGroup.SetEnabled(false);
    }
}
