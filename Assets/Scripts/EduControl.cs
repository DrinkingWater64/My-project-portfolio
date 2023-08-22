using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EduControl : MonoBehaviour
{
    private bool _isShowing = false;

    //public UIControl ui;
    VisualElement root;
    private GroupBox _eduGroup;


    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _eduGroup = root.Q<GroupBox>("EDU");

    }

    // Start is called before the first frame update
    void Start()
    {
        _eduGroup.SetEnabled(false);
        _eduGroup.style.display = DisplayStyle.None;
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
                ShowEDU();
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
                HideEDU();
            }
        }
    }

    public void ShowEDU()
    {
        _eduGroup.style.display = DisplayStyle.Flex;
        _eduGroup.SetEnabled(true);
    }
    public void HideEDU()
    {
        _eduGroup.SetEnabled(false);
    }
}
