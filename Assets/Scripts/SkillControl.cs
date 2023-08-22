using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class SkillControl : MonoBehaviour
{
    private bool _isShowing = false;

    //public UIControl ui;

    public VisualElement root;
    private GroupBox _skillGroup;

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _skillGroup = root.Q<GroupBox>("SKILLS");
    }

    // Start is called before the first frame update
    void Start()
    {
        _skillGroup.SetEnabled(false);
        _skillGroup.style.display = DisplayStyle.None;
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
                //ui.ShowSKill();
                _skillGroup.style.display = DisplayStyle.Flex;
                _skillGroup.SetEnabled(true);
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
                //ui.HideSkill();
                _skillGroup.SetEnabled(false);
            }
        }
    }


}
