using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ButtonWork : MonoBehaviour
{
    VisualElement root;
    private Button _button;
    public UnityEvent methodTocall;

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        _button = root.Q<Button>("button");

        _button.RegisterCallback<ClickEvent>(ev => GoToLink());

    }
    // Start is called before the first frame update
    private void GoToLink()
    {
        Debug.Log("works");
        methodTocall.Invoke();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
