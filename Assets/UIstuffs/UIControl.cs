using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIControl : MonoBehaviour
{
    VisualElement root;
    private Button _homeButton;
    private Button _projectsButton;
    private Button _resumeButton;
    private Button _contactButton;
    private ProgressBar _progress;

    [SerializeField] private Transform _homeT;
    [SerializeField] private Transform _projectT;
    [SerializeField] private Transform _contactT;

    public RocketControl rocket;
    public Transform _end;
    private float _distance = 0f;

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        _homeButton = root.Q<Button>("Home");
        _projectsButton = root.Q<Button>("Projects");
        _resumeButton = root.Q<Button>("Resume");
        _contactButton = root.Q<Button>("Contact");
        _progress = root.Q<ProgressBar>("ProgressBar");

        _homeButton.RegisterCallback<ClickEvent>(ev => GoHome());
        _projectsButton.RegisterCallback<ClickEvent>(ev => GoProjects());
        _resumeButton.RegisterCallback<ClickEvent>(ev => GoResume());
        _contactButton.RegisterCallback<ClickEvent>(ev => GoContact());
    }

    private void Start()
    {
        //Debug.Log());
        _distance = Vector3.Distance(rocket.transform.position, _end.position);
    }
    private void Update()
    {

        float val =  ((_distance - Vector3.Distance(rocket.transform.position, _end.position)) / _distance) * 100;
        _progress.value = val;
    }


    private void GoHome()
    {
        Debug.Log("home");
        rocket.MoveToTransform(_homeT);
    }

    private void GoProjects()
    {
        Debug.Log("pressed projects");
        rocket.MoveToTransform(_projectT);
    }

    public void GoResume()
    {
        Debug.Log("Pressed Resume");
        Application.OpenURL("https://www.dropbox.com/s/aefucxrk87u2gjr/Abdullah%20Al%20Muti.pdf?dl=0");
    }

    private void GoContact()
    {
        rocket.MoveToTransform(_contactT);
    }



}
