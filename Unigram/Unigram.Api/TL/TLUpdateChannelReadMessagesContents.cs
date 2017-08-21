// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelReadMessagesContents : TLUpdateBase 
	{
		public Int32 ChannelId { get; set; }
		public TLVector<Int32> Messages { get; set; }

		public TLUpdateChannelReadMessagesContents() { }
		public TLUpdateChannelReadMessagesContents(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelReadMessagesContents; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
			Messages = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x89893B45);
			to.Write(ChannelId);
			to.WriteObject(Messages);
		}
	}
}