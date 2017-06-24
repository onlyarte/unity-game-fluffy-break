using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaserGroup : ButtonAbstract
{
    public List<Laser> lasers;

    protected override IEnumerator ButtonEnterAction()
    {
        yield return new WaitForSeconds(0);
        lasers.ForEach(delegate (Laser laser)
        {
            laser.LaserOff();
        });
    }

    protected override IEnumerator ButtonExitAction()
    {

        yield return new WaitForSeconds(3);
        lasers.ForEach(delegate (Laser laser)
        {
            laser.LaserOn();
        });
    }

}
