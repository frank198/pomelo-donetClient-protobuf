using ProtoBuf;
using System.IO;


namespace Pomelo.DotNetClient
{
	public class EntityObject
	{
		public static byte[] Serialize(IExtensible msg)
		{
			byte[] result;
			using (var stream = new MemoryStream())
			{
				Serializer.Serialize(stream, msg);
				result = stream.ToArray();
			}
			return result;
		}

		/// <summary> 
		/// 将 byte[] 转成 Stream 
		/// </summary> 
		public static Stream BytesToStream(byte[] bytes)
		{
			Stream stream = new MemoryStream(bytes);
			return stream;
		}

		/// <summary>
		/// Gets the byteto string.
		/// </summary>
		/// <returns>The byteto string.</returns>
		/// <param name="content">Content.</param>
		/// <param name="startindex">Startindex.</param>
		/// <param name="countindex">Countindex.</param>
		public static string GetBytetoStringForUTF8(byte[] content)
		{
			return System.Text.Encoding.UTF8.GetString(content).Trim('\0');//BitConverter.ToString ();
		}

	}
}
