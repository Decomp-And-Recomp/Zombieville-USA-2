using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public class TrafficStats
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CTimestampOfLastAck_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CTimestampOfLastReliableCommand_003Ek__BackingField;

		public int PackageHeaderSize { get; internal set; }

		public int ReliableCommandCount { get; internal set; }

		public int UnreliableCommandCount { get; internal set; }

		public int FragmentCommandCount { get; internal set; }

		public int ControlCommandCount { get; internal set; }

		public int TotalPacketCount { get; internal set; }

		public int TotalCommandsInPackets { get; internal set; }

		public int ReliableCommandBytes { get; internal set; }

		public int UnreliableCommandBytes { get; internal set; }

		public int FragmentCommandBytes { get; internal set; }

		public int ControlCommandBytes { get; internal set; }

		public int TotalCommandBytes
		{
			get
			{
				return ReliableCommandBytes + UnreliableCommandBytes + FragmentCommandBytes + ControlCommandBytes;
			}
		}

		public int TotalPacketBytes
		{
			get
			{
				return TotalCommandBytes + TotalPacketCount * PackageHeaderSize;
			}
		}

		public int TimestampOfLastAck
		{
			[CompilerGenerated]
			set
			{
				_003CTimestampOfLastAck_003Ek__BackingField = value;
			}
		}

		public int TimestampOfLastReliableCommand
		{
			[CompilerGenerated]
			set
			{
				_003CTimestampOfLastReliableCommand_003Ek__BackingField = value;
			}
		}

		internal TrafficStats(int packageHeaderSize)
		{
			PackageHeaderSize = packageHeaderSize;
		}

		internal void CountControlCommand(int size)
		{
			ControlCommandBytes += size;
			ControlCommandCount++;
		}

		internal void CountReliableOpCommand(int size)
		{
			ReliableCommandBytes += size;
			ReliableCommandCount++;
		}

		internal void CountUnreliableOpCommand(int size)
		{
			UnreliableCommandBytes += size;
			UnreliableCommandCount++;
		}

		internal void CountFragmentOpCommand(int size)
		{
			FragmentCommandBytes += size;
			FragmentCommandCount++;
		}

		public override string ToString()
		{
			return string.Format("TotalPacketBytes: {0} TotalCommandBytes: {1} TotalPacketCount: {2} TotalCommandsInPackets: {3}", TotalPacketBytes, TotalCommandBytes, TotalPacketCount, TotalCommandsInPackets);
		}
	}
}
