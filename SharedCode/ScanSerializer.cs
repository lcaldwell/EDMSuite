using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

using ICSharpCode.SharpZipLib.Zip;

namespace Data.Scans
{
	/// <summary>
	/// Summary description for ScanSerializer.
	/// </summary>
	public class ScanSerializer
	{

		private XmlSerializer xmls;

		public ScanSerializer()
		{
			xmls = new XmlSerializer(typeof(Scan));
		}

		public void SerializeScanAsZippedXML(Stream stream, Scan scan)
		{
			ZipOutputStream zippedStream = new ZipOutputStream(stream);
			zippedStream.SetLevel(5);
			ZipEntry entry = new ZipEntry("average.xml");
			zippedStream.PutNextEntry(entry);
			xmls.Serialize(zippedStream, scan);
			zippedStream.Finish();
			zippedStream.Close();
			stream.Close();
		}

		public Scan DeserializeScanFromXML(String filePath)
		{
			Stream scanStream = new FileStream(filePath, FileMode.Create);
			Scan scan = (Scan)xmls.Deserialize(scanStream);
			scanStream.Close();
			return scan;
		}

		public Scan DeserializeScanFromZippedXML(String zipFilePath, String scanFileName)
		{
			FileStream zipFileStream = new FileStream(zipFilePath, FileMode.Open);
			ZipInputStream zippedStream = new ZipInputStream(zipFileStream);
			ZipEntry zipEntry;
			Scan scan = null;
			while ((zipEntry = zippedStream.GetNextEntry()) != null) 
			{
				if (zipEntry.Name == scanFileName) 
				{
					scan = (Scan)xmls.Deserialize(zippedStream);
					break;
				}
			}
			zippedStream.Close();
			return scan;
		}

		public void SerializeScanAsBinary(String filePath, Scan scan)
		{
			Stream scanStream = new FileStream(filePath, FileMode.Create);
			(new BinaryFormatter()).Serialize(scanStream, scan);
			scanStream.Close();
		}

		public Scan DeserializeScanAsBinary(String filePath)
		{
			Stream scanStream = new FileStream(filePath, FileMode.Create);
			Scan scan = (Scan)(new BinaryFormatter()).Deserialize(scanStream);
			scanStream.Close();
			return scan;
		}


	}
}
