using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorButton : ButtonAbstract {

    public Door door;
    public float ExitTime = 5f;

    protected override IEnumerator ButtonEnterAction()
    {
        yield return new WaitForSeconds(0);
        door.DoorOpen();
    }

    protected override IEnumerator ButtonExitAction()
    {
        yield return new WaitForSeconds(ExitTime);
        door.DoorClose();
    }
}
