namespace CSharpLab.AirTransport;

public sealed class TransportEventArgs : EventArgs
{
	public int LastId { get; }
	public int NewId { get; }
	public TransportEventArgs(int lastId, int newId)
	{
		LastId = lastId;
		NewId = newId;
	}
}
