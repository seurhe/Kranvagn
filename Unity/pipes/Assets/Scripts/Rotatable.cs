using UnityEngine;

public class Rotatable : Modifiable {

    private Vector3 _dragStartAngles;
    public float Modifyer = 400;

    public override void ModificationStarted()
    {
        _dragStartAngles = transform.localEulerAngles;
        base.ModificationStarted();
    }

    public override void PerformModification()
    {
        var offset = _gestureManager.ManipulationOffset;
        var angleMods = new Vector3(-offset.z, offset.x, offset.y);
        if (LockX)
            angleMods.x = 0;
        if (LockY)
            angleMods.y = 0;
        if (LockZ)
            angleMods.z = 0;


        transform.localEulerAngles = _dragStartAngles + angleMods * Modifyer;
    }
}
