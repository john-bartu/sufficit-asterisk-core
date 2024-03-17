using Sufficit.Asterisk.Manager.Events.Abstracts;

namespace Sufficit.Asterisk.Manager.Events
{
	/// <summary>
	/// An AlarmEvent is triggered when a Zap channel leaves alarm state.<br/>
	/// It is implemented in channels/chan_zap.c
	/// </summary>
	public sealed class AlarmClearEvent : ManagerEvent
	{

	}
}