// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.reportSpam.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesReportSpam : TLObject
	{
		public TLInputPeerBase Peer { get; set; }

		public TLMessagesReportSpam() { }
		public TLMessagesReportSpam(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReportSpam; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xCF1592DB);
			to.WriteObject(Peer);
		}
	}
}