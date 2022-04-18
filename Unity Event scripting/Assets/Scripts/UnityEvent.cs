using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEvent : MonoBehaviour
{
    public UnityEvent TriggerEnteerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    [SerializedField] private UnityEvent myTrigger;

    private void OnTriggerEnteer(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
    
    // Detects if any Key had been pressed down.

    void Update()
    {
        if (Input.andKEyDown)
        {
            Debug.Log("A key of mouse click had been detected");
        }
    }

    private UnityEvent m_MyEvent;

    void start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();
        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
    
    // A Light used in the Scene and needed by MyGameMEthod().
    public Light light;

    void MyGameMethod()
    {
        // Message with a GameObject name.
        Debug.Log("Hello: " + gameObject);
        
        // Message with light type This is an Object example.
        Debug.Log(light.type);
        
        // Message using rich text.
        Debug.Log("<color=red>Error: </color>AssetBundle not found");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
