using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{

    public Rigidbody2D triggerBody; //on fait passer le Player dans la variable RigidBody2D
    public UnityEvent onTriggerEnter;


    void OnTriggerEnter2D(Collider2D other){
        //do not trigger if there's no trigger target object
        if (triggerBody == null) return;

        //only trigger if the triggerBody matches
        var hitRb = other.attachedRigidbody; //other = paramètre que l'on reçoit
        if (hitRb == triggerBody){
            onTriggerEnter.Invoke();
        }
    }

}
