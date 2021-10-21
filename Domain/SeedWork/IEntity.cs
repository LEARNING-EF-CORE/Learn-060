namespace Domain.SeedWork
{
	public interface IEntity<T>
	{
		T Id { get; set; }
	}
}
