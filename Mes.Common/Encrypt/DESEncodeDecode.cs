using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Common.Encrypt
{
    public  class DESEncodeDecode
    {
		private  const string CIV = "Mi9l/+7Zujhy12se6Yjy111A";

		private const string CKEY = "jkHuIy9D/9i=";

		public static string Type
		{
			get
			{
				return "2";
			}
		}

		public static string Encode(string sourceData)
		{
			SymmetricAlgorithm symmetricAlgorithm = new DESCryptoServiceProvider();
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(Convert.FromBase64String("jkHuIy9D/9i="), Convert.FromBase64String("Mi9l/+7Zujhy12se6Yjy111A"));
			byte[] bytes = Encoding.ASCII.GetBytes(sourceData);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public static string Decode(string targeData)
		{
			SymmetricAlgorithm symmetricAlgorithm = new DESCryptoServiceProvider();
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(Convert.FromBase64String("jkHuIy9D/9i="), Convert.FromBase64String("Mi9l/+7Zujhy12se6Yjy111A"));
			byte[] array = Convert.FromBase64String(targeData);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(memoryStream.ToArray());
		}
	}
}
