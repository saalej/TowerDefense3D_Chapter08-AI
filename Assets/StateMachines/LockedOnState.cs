using UnityEngine;
using System.Collections;

public class LockedOnState : StateMachineBehaviour {

    GameObject player;
    Tower tower;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    // Se llama a OnStateEnter cuando comienza una transición y la máquina de estado comienza a evaluar este estado.
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        
        player = GameObject.FindGameObjectWithTag("Player");
        tower = animator.gameObject.GetComponent<Tower>();
        animator.gameObject.transform.LookAt(player.transform);
        tower.LockedOn = true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    // OnStateUpdate se llama en cada marco de actualización entre las devoluciones de llamada OnStateEnter y OnStateExit
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        
        animator.gameObject.transform.LookAt(player.transform);
	}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    // Se llama a OnStateExit cuando finaliza una transición y la máquina de estado termina de evaluar este estado.
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        
        animator.gameObject.transform.rotation = Quaternion.identity;
        tower.LockedOn = false;
    }
}
