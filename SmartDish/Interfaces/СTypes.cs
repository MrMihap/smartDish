using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDish.Interfaces
{
  using  TTime = System.UInt64 ;
  using TData = System.Double;
  using TStimIndex = System.Int16;
  using TAbsStimIndex = System.UInt64;
  using TRawData = UInt16;
  public class TCmpDataPacket : Dictionary<int, sbyte[]>
  {
  }
  
  public class TRawDataPacket : Dictionary<int, ushort[]>
  {
  }

  public class TFltDataPacket : Dictionary<int, double[]>
  {
  }



  public class CPack
  {
    private TTime start;
    private Int32 length;
    private TData[] noiseLevel;
    private TFltDataPacket data;
    public TTime Start { get { return start; } }
    public TData[] NoiseLevel { get { return noiseLevel; } }
    public Int32 Length { get { return length; } set { length = Length; } }
    public TFltDataPacket Data { get { return data; } }
    public bool EOP { get { return length != 0; } }

    public CPack(TTime _start, Int32 _length, TFltDataPacket _data = null, TData[] _noiseLevel = null)
    {
      start = _start;
      length = _length;
      data = _data;
      noiseLevel = _noiseLevel;
    }
  }
  public struct SEvokedPack
  {
    public CPack Burst;
    public TAbsStimIndex stim;
  }
}
