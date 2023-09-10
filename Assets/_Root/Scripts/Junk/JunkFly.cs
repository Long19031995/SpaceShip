public class JunkFly : ObjectFly, IReset
{
    public void Reset()
    {
        this.moveSpeed = 0.5f;
    }
}
