public class Desk : Container
{
    protected override bool IsScrollValid(Scroll scroll)
    {
        return scroll != null && !scrolls.Contains(scroll) && scrolls.Count == 0;
    }
}
