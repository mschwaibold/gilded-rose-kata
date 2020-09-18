namespace csharp.UpdateItemStrategies
{
    public interface IUpdateItemStrategy
    {
        void ApplyTo(ItemProxy item);
    }
}
