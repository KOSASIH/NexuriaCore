using System;
using System.Collections.Generic;

namespace IF
{
  public class InteroperabilityFramework
  {
    private readonly List<BlockchainNetwork> _blockchainNetworks;
    private readonly List<TraditionalFinancialSystem> _traditionalFinancialSystems;
    private readonly List<IoTDevice> _iotDevices;

    public InteroperabilityFramework(IFConfig config)
    {
      _blockchainNetworks = config.BlockchainNetworks;
      _traditionalFinancialSystems = config.TraditionalFinancialSystems;
      _iotDevices = config.IoTDevices;
    }

    public void IntegrateWithBlockchainNetwork(BlockchainNetwork network)
    {
      // Integrate Pi Coin with the blockchain network using the corresponding adapter
      var adapter = network.Adapter;
      adapter.Integrate();
    }

    public void IntegrateWithTraditionalFinancialSystem( TraditionalFinancialSystem system)
    {
      // Integrate Pi Coin with the traditional financial system using the corresponding adapter
      var adapter = system.Adapter;
      adapter.Integrate();
    }

    public void IntegrateWithIoTDevice(IoTDevice device)
    {
      // Integrate Pi Coin with the IoT device using the corresponding adapter
      var adapter = device.Adapter;
      adapter.Integrate();
    }
  }
}
