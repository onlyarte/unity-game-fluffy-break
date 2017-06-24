using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOffButton : ButtonAbstract {

    public Laser laser;

    protected override IEnumerator ButtonEnterAction()
    {
        yield return new WaitForSeconds(0);
        laser.LaserOff();
    }

    protected override IEnumerator ButtonExitAction()
    {
        yield return new WaitForSeconds(3);
        laser.LaserOn();
    }
}
