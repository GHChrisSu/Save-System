using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Patrol")]
public class PatrolAction : Action {

    public override void Act(StateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(StateController controller)
    {
        controller.navMeshAgent.destination = controller.wayPointList[controller.nexWayPoint].position;
        controller.navMeshAgent.Resume();

        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance 
            && !controller.navMeshAgent.pathPending)
        {
            controller.nexWayPoint = (controller.nexWayPoint + 1) % controller.wayPointList.Count;
        }
    }
}
