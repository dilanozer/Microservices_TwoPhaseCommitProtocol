namespace Coordinator.Services.Abstractions
{
    public interface ITransactionService
	{
        // request neticesinde olusan transaction in db deki karsiligini olusturma
        Task<Guid> CreateTransactionAsync();

		// transaction olusturulduktan sonra servislerin hazir olup olmadiklarini degerlendirme
		Task PrepareServicesAsync(Guid transactionId);

		// prepare den gelenlerin kontrolu
		Task<bool> CheckReadyServicesAsync(Guid transactionId);

		// servisler hazir ise commit operasyonu gerceklestirme
		Task CommitAsync(Guid transactionId);

		// transaction in basarili bir sekilde sonlanip sonlanmadigi kontrolu
		Task<bool> CheckTransactionStateServicesAsync(Guid transactionId);

		// transaction basarisizsa yapilan butun islemleri geri alma
		Task RollbackAsync(Guid transactionId);
	}
}

