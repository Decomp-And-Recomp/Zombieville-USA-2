using System;
using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	public class PhotonPeer
	{
		public const bool NoSocket = false;

		internal PeerBase peerBase;

		private readonly object SendOutgoingLockObject = new object();

		private readonly object DispatchLockObject = new object();

		private readonly object EnqueueLock = new object();

		public Type SocketImplementation
		{
			set
			{
				peerBase.SocketImplementation = value;
			}
		}

		public DebugLevel DebugOut
		{
			get
			{
				return peerBase.debugOut;
			}
			set
			{
				peerBase.debugOut = value;
			}
		}

		public IPhotonPeerListener Listener
		{
			get
			{
				return peerBase.Listener;
			}
			protected set
			{
				peerBase.Listener = value;
			}
		}

		public bool TrafficStatsEnabled
		{
			get
			{
				return peerBase.TrafficStatsEnabled;
			}
			set
			{
				peerBase.TrafficStatsEnabled = value;
			}
		}

		public long TrafficStatsElapsedMs
		{
			get
			{
				return peerBase.TrafficStatsEnabledTime;
			}
		}

		public TrafficStats TrafficStatsIncoming
		{
			get
			{
				return peerBase.TrafficStatsIncoming;
			}
		}

		public TrafficStats TrafficStatsOutgoing
		{
			get
			{
				return peerBase.TrafficStatsOutgoing;
			}
		}

		public TrafficStatsGameLevel TrafficStatsGameLevel
		{
			get
			{
				return peerBase.TrafficStatsGameLevel;
			}
		}

		public byte QuickResendAttempts
		{
			get
			{
				return peerBase.QuickResendAttempts;
			}
			set
			{
				peerBase.QuickResendAttempts = (byte)((value > 4) ? 4 : value);
			}
		}

		public PeerStateValue PeerState
		{
			get
			{
				if (peerBase.peerConnectionState == PeerBase.ConnectionStateValue.Connected && !peerBase.ApplicationIsInitialized)
				{
					return PeerStateValue.InitializingApplication;
				}
				return (PeerStateValue)peerBase.peerConnectionState;
			}
		}

		public int LimitOfUnreliableCommands
		{
			get
			{
				return peerBase.limitOfUnreliableCommands;
			}
			set
			{
				peerBase.limitOfUnreliableCommands = value;
			}
		}

		public bool CrcEnabled
		{
			get
			{
				return peerBase.crcEnabled;
			}
			set
			{
				if (peerBase.peerConnectionState != 0)
				{
					throw new Exception("CrcEnabled can only be set while disconnected.");
				}
				peerBase.crcEnabled = value;
			}
		}

		public int PacketLossByCrc
		{
			get
			{
				return peerBase.packetLossByCrc;
			}
		}

		public int ResentReliableCommands
		{
			get
			{
				return (UsedProtocol == ConnectionProtocol.Udp) ? ((EnetPeer)peerBase).reliableCommandsRepeated : 0;
			}
		}

		public int SentCountAllowance
		{
			get
			{
				return peerBase.sentCountAllowance;
			}
			set
			{
				peerBase.sentCountAllowance = value;
			}
		}

		public int TimePingInterval
		{
			set
			{
				peerBase.timePingInterval = value;
			}
		}

		public int DisconnectTimeout
		{
			get
			{
				return peerBase.DisconnectTimeout;
			}
			set
			{
				peerBase.DisconnectTimeout = value;
			}
		}

		public int ServerTimeInMilliSeconds
		{
			get
			{
				return peerBase.serverTimeOffsetIsAvailable ? (peerBase.serverTimeOffset + SupportClass.GetTickCount()) : 0;
			}
		}

		public SupportClass.IntegerMillisecondsDelegate LocalMsTimestampDelegate
		{
			set
			{
				if (PeerState != 0)
				{
					throw new Exception("LocalMsTimestampDelegate only settable while disconnected. State: " + PeerState);
				}
				SupportClass.IntegerMilliseconds = value;
			}
		}

		public int RoundTripTime
		{
			get
			{
				return peerBase.roundTripTime;
			}
		}

		public int RoundTripTimeVariance
		{
			get
			{
				return peerBase.roundTripTimeVariance;
			}
		}

		public int TimestampOfLastSocketReceive
		{
			get
			{
				return peerBase.timestampOfLastReceive;
			}
		}

		public string ServerAddress
		{
			get
			{
				return peerBase.ServerAddress;
			}
			set
			{
				if ((int)DebugOut >= 1)
				{
					Listener.DebugReturn(DebugLevel.ERROR, "Failed to set ServerAddress. Can be set only when using HTTP.");
				}
			}
		}

		public ConnectionProtocol UsedProtocol
		{
			get
			{
				return peerBase.usedProtocol;
			}
		}

		public virtual bool IsSimulationEnabled
		{
			get
			{
				return NetworkSimulationSettings.IsSimulationEnabled;
			}
			set
			{
				if (value == NetworkSimulationSettings.IsSimulationEnabled)
				{
					return;
				}
				lock (SendOutgoingLockObject)
				{
					NetworkSimulationSettings.IsSimulationEnabled = value;
				}
			}
		}

		public NetworkSimulationSet NetworkSimulationSettings
		{
			get
			{
				return peerBase.NetworkSimulationSettings;
			}
		}

		public bool IsEncryptionAvailable
		{
			get
			{
				return peerBase.isEncryptionAvailable;
			}
		}

		public bool IsSendingOnlyAcks
		{
			set
			{
				lock (SendOutgoingLockObject)
				{
					peerBase.IsSendingOnlyAcks = value;
				}
			}
		}

		public PhotonPeer(ConnectionProtocol protocolType)
		{
			switch (protocolType)
			{
			case ConnectionProtocol.Tcp:
				peerBase = new TPeer();
				peerBase.usedProtocol = protocolType;
				break;
			case ConnectionProtocol.Udp:
				peerBase = new EnetPeer();
				peerBase.usedProtocol = protocolType;
				break;
			default:
				if (protocolType != ConnectionProtocol.WebSocketSecure)
				{
					break;
				}
				goto case ConnectionProtocol.WebSocket;
			case ConnectionProtocol.WebSocket:
				peerBase = new TPeer
				{
					DoFraming = false
				};
				peerBase.usedProtocol = protocolType;
				break;
			}
		}

		public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
			: this(protocolType)
		{
			Listener = listener;
		}

		public void TrafficStatsReset()
		{
			peerBase.InitializeTrafficStats();
			peerBase.TrafficStatsEnabled = true;
		}

		public virtual bool Connect(string serverAddress, string applicationName)
		{
			lock (DispatchLockObject)
			{
				lock (SendOutgoingLockObject)
				{
					return peerBase.Connect(serverAddress, applicationName);
				}
			}
		}

		public virtual void Disconnect()
		{
			lock (DispatchLockObject)
			{
				lock (SendOutgoingLockObject)
				{
					peerBase.Disconnect();
				}
			}
		}

		public virtual void StopThread()
		{
			lock (DispatchLockObject)
			{
				lock (SendOutgoingLockObject)
				{
					peerBase.StopConnection();
				}
			}
		}

		public virtual void FetchServerTimestamp()
		{
			peerBase.FetchServerTimestamp();
		}

		public bool EstablishEncryption()
		{
			return peerBase.ExchangeKeysForEncryption();
		}

		public virtual void Service()
		{
			while (DispatchIncomingCommands())
			{
			}
			while (SendOutgoingCommands())
			{
			}
		}

		public virtual bool SendOutgoingCommands()
		{
			if (TrafficStatsEnabled)
			{
				TrafficStatsGameLevel.SendOutgoingCommandsCalled();
			}
			lock (SendOutgoingLockObject)
			{
				return peerBase.SendOutgoingCommands();
			}
		}

		public virtual bool SendAcksOnly()
		{
			if (TrafficStatsEnabled)
			{
				TrafficStatsGameLevel.SendOutgoingCommandsCalled();
			}
			lock (SendOutgoingLockObject)
			{
				return peerBase.SendAcksOnly();
			}
		}

		public virtual bool DispatchIncomingCommands()
		{
			peerBase.ByteCountCurrentDispatch = 0;
			if (TrafficStatsEnabled)
			{
				TrafficStatsGameLevel.DispatchIncomingCommandsCalled();
			}
			lock (DispatchLockObject)
			{
				return peerBase.DispatchIncomingCommands();
			}
		}

		public string VitalStatsToString(bool all)
		{
			if (TrafficStatsGameLevel == null)
			{
				return "Stats not available. Use PhotonPeer.TrafficStatsEnabled.";
			}
			if (!all)
			{
				return string.Format("Rtt(variance): {0}({1}). Ms since last receive: {2}. Stats elapsed: {4}sec.\n{3}", RoundTripTime, RoundTripTimeVariance, SupportClass.GetTickCount() - TimestampOfLastSocketReceive, TrafficStatsGameLevel.ToStringVitalStats(), TrafficStatsElapsedMs / 1000);
			}
			return string.Format("Rtt(variance): {0}({1}). Ms since last receive: {2}. Stats elapsed: {6}sec.\n{3}\n{4}\n{5}", RoundTripTime, RoundTripTimeVariance, SupportClass.GetTickCount() - TimestampOfLastSocketReceive, TrafficStatsGameLevel.ToStringVitalStats(), TrafficStatsIncoming.ToString(), TrafficStatsOutgoing.ToString(), TrafficStatsElapsedMs / 1000);
		}

		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable)
		{
			return OpCustom(customOpCode, customOpParameters, sendReliable, 0);
		}

		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId)
		{
			lock (EnqueueLock)
			{
				return peerBase.EnqueueOperation(customOpParameters, customOpCode, sendReliable, channelId, false);
			}
		}

		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId, bool encrypt)
		{
			if (encrypt && !IsEncryptionAvailable)
			{
				throw new ArgumentException("Can't use encryption yet. Exchange keys first.");
			}
			lock (EnqueueLock)
			{
				return peerBase.EnqueueOperation(customOpParameters, customOpCode, sendReliable, channelId, encrypt);
			}
		}

		public static bool RegisterType(Type customType, byte code, SerializeStreamMethod serializeMethod, DeserializeStreamMethod constructor)
		{
			return Protocol.TryRegisterType(customType, code, serializeMethod, constructor);
		}
	}
}
