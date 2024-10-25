using Coordinator.Enums;

namespace Coordinator.Models
{
    public record NodeState(Guid TransactionId)
	{
		public Guid Id { get; set; }
		// Prepare Phase in durumunu ifade eden property
		public ReadyType IsReady { get; set; }
		// Commit Phase neticesinde islemin basarili tamamlanip, tamamlanmadigini ifade eden property
		public TransactionState TransactionState { get; set; }
		public Node Node { get; set; }
	}
}

