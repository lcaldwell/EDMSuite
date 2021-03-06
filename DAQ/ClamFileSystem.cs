using System;

namespace DAQ.Environment
{
	/// <summary>
	/// 
	/// </summary>
	public class ClamFileSystem : DAQ.Environment.FileSystem
	{
		public ClamFileSystem()
		{
			Paths.Add("settingsPath","d:\\mike\\data\\settings\\");
			Paths.Add("scanMasterDataPath", "d:\\mike\\data\\coldmols\\");
			Paths.Add("mathPath", "c:/program files/wolfram research/mathematica/6.0/mathkernel.exe");
			Paths.Add("fakeData","d:\\mike\\data\\examples\\");
            Paths.Add("decelerationUtilitiesPath", "d:\\Mike\\Work\\");
            
			DataSearchPaths.Add(Paths["scanMasterDataPath"]);

			SortDataByDate = false;
		}
	}
}
