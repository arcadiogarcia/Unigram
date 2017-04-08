// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.reportEncryptedSpam.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesReportEncryptedSpam : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }

		public TLMessagesReportEncryptedSpam() { }
		public TLMessagesReportEncryptedSpam(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReportEncryptedSpam; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4B0C8C0F);
			to.WriteObject(Peer);
		}
	}
}