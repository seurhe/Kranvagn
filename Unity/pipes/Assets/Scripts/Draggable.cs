
public class Draggable : Modifiable {

    public float Modifyer = 4;

    public override void PerformModification()
    {
        var offset = _gestureManager.ManipulationOffset;
        if (LockX)
            offset.x = 0;
        if (LockY)
            offset.y = 0;
        if (LockZ)
            offset.z = 0;

        transform.localPosition = _dragStartPosition + offset*Modifyer;
    }
}
