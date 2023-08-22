using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DisplayDescription : MonoBehaviour
{
    [SerializeField]
    private Transform _anchor;
    VisualElement root;
    VisualElement card;
    Camera mainCam;
    // Start is called before the first frame update
    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        card = root.Q<VisualElement>("Card");
    }

    void Start()
    {
        mainCam = Camera.main;
        SetPosition();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        SetPosition();
    }

    public void SetPosition()
    {
        Vector2 newpos = RuntimePanelUtils.CameraTransformWorldToPanel(card.panel, _anchor.position, mainCam);
        card.transform.position = newpos;
    }
}
